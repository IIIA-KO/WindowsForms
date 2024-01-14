using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAPICodePack.Taskbar;

using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using System.Windows.Forms;
using System.Reflection;
using TaskManager.Database;
using TaskManager.Common;

namespace TaskManager.Window7
{

    /// <summary>
    /// Class to manage jump list
    /// </summary>
    public class TaskJumpList
    {

        #region Data Members

        private JumpList _jumpList;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize task jump list class
        /// </summary>
        public TaskJumpList()
        {
            InitTaskJumpList();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Show task items in the jump list
        /// </summary>
        /// <param name="tasks">task to be shown in jump list</param>
        /// <param name="jumpListDisplayStyle">Type of task</param>
        public void ShowTaskList(IQueryable<Task> tasks, JumpListDisplayStyle jumpListDisplayStyle)
        {


            _jumpList.ClearAllUserTasks();

            switch (jumpListDisplayStyle)
            {
                case JumpListDisplayStyle.ColorCategory:
                    {
                        ShowJumpListByColorCategory(tasks);
                        break;
                    }
                case JumpListDisplayStyle.Flag:
                    {
                        ShowJumpListByFlag(tasks);
                        break;
                    }
                case JumpListDisplayStyle.Priority:
                    {
                        ShowJumpListByPriority(tasks);
                        break;
                    }
            }

            _jumpList.Refresh();

        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initialize task jump list class
        /// </summary>
        private void InitTaskJumpList()
        {
            _jumpList = JumpList.CreateJumpList();

        }

        /// <summary>
        /// Show jump list by colors. 
        /// </summary>
        /// <param name="tasks">list of tasks</param>
        private void ShowJumpListByColorCategory(IQueryable<Task> tasks)
        {
            string[] colorCategories = Enum.GetNames(typeof(TaskCategory));


            foreach (string catName in colorCategories)
            {
                // Get task by color category
                IQueryable<Task> colorTask = tasks.Where(t => t.ColorCategory == catName);

                if (colorTask.Count() > 0)
                {
                    // Create jump list custom category
                    JumpListCustomCategory customList = new JumpListCustomCategory(catName);

                    // Add jump list category in list
                    _jumpList.AddCustomCategories(customList);

                    // Add tasks in custom category
                    foreach (Task task in colorTask)
                    {
                        string imagePath = "Resources\\" + catName + "_Category.ico";
                        AddTask(customList, task.Title, task.TaskID.ToString(), imagePath);
                    }
                }
            }
        }

        /// <summary>
        /// show jump list by flag
        /// </summary>
        /// <param name="tasks">list of tasks</param>
        private void ShowJumpListByFlag(IQueryable<Task> tasks)
        {
            string[] taskFlags = Enum.GetNames(typeof(TaskFlag));


            foreach (string flag in taskFlags)
            {
                IQueryable<Task> taskFlag = tasks.Where(t => t.Flag == flag);

                if (taskFlag.Count() > 0)
                {
                    JumpListCustomCategory customList = new JumpListCustomCategory(flag);

                    _jumpList.AddCustomCategories(customList);
                    foreach (Task task in taskFlag)
                    {
                        string imagePath = "Resources\\" + flag + "_Flag_Icon.ico";
                        AddTask(customList, task.Title, task.TaskID.ToString(), imagePath);
                    }
                }
            }
        }

        /// <summary>
        /// Show jump list by priority
        /// </summary>
        /// <param name="tasks">list of tasks</param>
        private void ShowJumpListByPriority(IQueryable<Task> tasks)
        {
            string[] taskPriorities = Enum.GetNames(typeof(TaskPriority));


            foreach (string priority in taskPriorities)
            {
                IQueryable<Task> taskPriority = tasks.Where(t => t.Priority == priority);

                if (taskPriority.Count() > 0)
                {
                    JumpListCustomCategory customList = new JumpListCustomCategory(priority);

                    _jumpList.AddCustomCategories(customList);
                    foreach (Task task in taskPriority)
                    {
                        string imagePath = "Resources\\" + priority + "_Priority_Icon.ico";
                        AddTask(customList, task.Title, task.TaskID.ToString(), imagePath);
                    }
                }
            }
        }

        /// <summary>
        /// Add task in the jump list
        /// </summary>
        /// <param name="customCategory">jump list custom category</param>
        /// <param name="text">title of jump list item</param>
        /// <param name="argument">argument</param>
        /// <param name="imagePath">icon path</param>
        private void AddTask(JumpListCustomCategory customCategory, string text, string argument, string imagePath)
        {

            // Get executable file path
            string path = Path.GetDirectoryName(Application.ExecutablePath);

            // Creat jump list link
            JumpListLink jumpListLink = new JumpListLink(Assembly.GetExecutingAssembly().Location, text);

            jumpListLink.Arguments = argument;
            jumpListLink.IconReference = new IconReference(Path.Combine(path, imagePath), 0);


            // Add link in category
            customCategory.AddJumpListItems(jumpListLink);

        }

        #endregion

    }
}
