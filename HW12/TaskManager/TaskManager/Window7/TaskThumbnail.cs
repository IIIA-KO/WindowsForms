using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Windows.Forms;
using TaskManager.Controls;
using System.Drawing;
using TaskManager.Database;

namespace TaskManager.Window7
{
    /// <summary>
    /// Class to manage thumbnail image.
    /// </summary>
    public class TaskThumbnail
    {

        #region Internal Enum Class

        /// <summary>
        /// Enum of task move direction
        /// </summary>
        private enum TaskDirection
        {
            /// <summary>
            /// Move back
            /// </summary>
            Back,
            /// <summary>
            /// Move Forward
            /// </summary>
            Forward
        }
        #endregion

        #region Data Memebrs

        ThumbnailViewer _controlToShow = null;

        ThumbnailToolbarButton _btnBack;
        ThumbnailToolbarButton _btnForward;
        ThumbnailToolbarButton _btnEdit;

        IntPtr _parentHandle;
        List<Task> _taskList = null;
        TaskManagerMainForm _mainForm = null;

        int _selectedIndex = 0;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor to initialize Thumbnail
        /// </summary>
        /// <param name="mainForm">parent form</param>
        /// <param name="parentHandle">parent handle</param>
        /// <param name="taskList">list of tasks to be shown</param>
        public TaskThumbnail(TaskManagerMainForm mainForm, IntPtr parentHandle, List<Task> taskList)
        {
            _mainForm = mainForm;
            _parentHandle = parentHandle;
            _taskList = taskList;
            _controlToShow = new ThumbnailViewer();

            InitializeThumbnail();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Refresh thumbnail image
        /// </summary>
        /// <param name="taskList">task list</param>
        public void RefreshTaskThumbnail(List<Task> taskList)
        {
            _selectedIndex = 0;
            _taskList = taskList;

            SetThumbnail();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Initialize task thumbnail
        /// </summary>
        private void InitializeThumbnail()
        {


            if (!HasThumbnailControl(_controlToShow))
            {


                // Back Button
                _btnBack = new ThumbnailToolbarButton(Properties.Resources.Back, "Previous Task");
                _btnBack.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(_btnBack_Click);


                // Forwaard
                _btnForward = new ThumbnailToolbarButton(Properties.Resources.Forward, "Next Task");
                _btnForward.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(_btnForward_Click);

                // Edit
                _btnEdit = new ThumbnailToolbarButton(Properties.Resources.edit_Icon, "Edit Task");
                _btnEdit.Click += new EventHandler<ThumbnailButtonClickedEventArgs>(_btnEdit_Click);
                

                TabbedThumbnail thumbnail = new TabbedThumbnail(_parentHandle, _controlToShow);
                thumbnail.DisplayFrameAroundBitmap = true;
                thumbnail.SetWindowIcon(Properties.Resources.Task_manager);
                thumbnail.Title = "Task Manager";
                thumbnail.Tooltip = "Task Manager";
                thumbnail.TabbedThumbnailClosed += new EventHandler<TabbedThumbnailEventArgs>(thumbnail_TabbedThumbnailClosed);
                thumbnail.TabbedThumbnailActivated += new EventHandler<TabbedThumbnailEventArgs>(thumbnail_TabbedThumbnailActivated);
                
                // Add Buttons in the tool bar
                TaskbarManager.Instance.ThumbnailToolbars.AddButtons(_controlToShow.Handle, _btnBack, _btnForward, _btnEdit);

                // Add Tabbed preview
                TaskbarManager.Instance.TabbedThumbnail.AddThumbnailPreview(thumbnail);

                // Set active tab
                TaskbarManager.Instance.TabbedThumbnail.SetActiveTab(_controlToShow);

                // Set Thumnail preview
                SetThumbnail();
            }
        }

        /// <summary>
        /// Show next/previous task
        /// </summary>
        /// <param name="taskDirection">direction of task</param>
        private void MoveTask(TaskDirection taskDirection)
        {

            if (taskDirection == TaskDirection.Back && _selectedIndex > 0)
            {

                _selectedIndex--;


            }
            else if (taskDirection == TaskDirection.Forward && _selectedIndex < _taskList.Count - 1)
            {
                _selectedIndex++;
            }

            SetThumbnail();
        }

        /// <summary>
        /// Set thumbnail of selected task
        /// </summary>
        private void SetThumbnail()
        {

            TabbedThumbnail preview = TaskbarManager.Instance.TabbedThumbnail.GetThumbnailPreview(_controlToShow);
            if (preview != null)
            {

                Task task = null;
                string toolTip = "Task Manager";
                if (_taskList.Count > _selectedIndex)
                {
                    task = _taskList[_selectedIndex];
                    toolTip = task.Title;
                }

                _controlToShow.LoadTaskData(task);
                preview.Tooltip = toolTip;

                Bitmap bitmap = new Bitmap(_controlToShow.Width, _controlToShow.Height);
                bitmap = _controlToShow.Image;
                preview.SetImage(bitmap);
                TaskbarManager.Instance.TabbedThumbnail.SetActiveTab(_controlToShow);

            }

        }

        /// <summary>
        /// return true if thumbnail is exist
        /// </summary>
        /// <param name="control">control to find for thumnaikl</param>
        /// <returns>return true if found</returns>
        private bool HasThumbnailControl(Control control)
        {

            return TaskbarManager.Instance.TabbedThumbnail.IsThumbnailPreviewAdded(control);

        }

        #endregion

        #region Events

        void thumbnail_TabbedThumbnailClosed(object sender, TabbedThumbnailEventArgs e)
        {

            e.TabbedThumbnail.TabbedThumbnailClosed -= new EventHandler<TabbedThumbnailEventArgs>(thumbnail_TabbedThumbnailClosed);

            Application.Exit();

        }
        
        void thumbnail_TabbedThumbnailActivated(object sender, TabbedThumbnailEventArgs e)
        {
            if (_mainForm.WindowState != FormWindowState.Maximized)
                _mainForm.WindowState = FormWindowState.Maximized;
        }
        
        void _btnForward_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            MoveTask(TaskDirection.Forward);
        }

        void _btnEdit_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            if (_taskList.Count > _selectedIndex)
            {
                int taskID = _taskList[_selectedIndex].TaskID;

                _mainForm.OpenAddNewTaskForm(taskID);
            }
        }

        void _btnBack_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            MoveTask(TaskDirection.Back);
        }

        #endregion

    }
}
