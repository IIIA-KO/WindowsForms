using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAPICodePack.Taskbar;
using TaskManager.Common;
using System.Drawing; 

namespace TaskManager.Window7
{
    /// <summary>
    /// Class to handle Window 7 task bar operations
    /// </summary>
    public class TaskBar
    {

        #region Public Methods

        /// <summary>
        /// Method to set task bar progress value
        /// </summary>
        /// <param name="value">value</param>
        public static void SetProgressValue(int value)
        {

            TaskbarProgressBarState state = TaskbarProgressBarState.Normal;

            TaskbarManager.Instance.SetProgressState(state);
            TaskbarManager.Instance.SetProgressValue(value, 100);

        }

        /// <summary>
        /// method to clear task bar progress value
        /// </summary>
        public static void ClearProgressValue()
        {
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.NoProgress);
        }

        /// <summary>
        /// method to set task bar icon
        /// </summary>
        /// <param name="icon">icon</param>
        public static void SetTaskBarIcon(Icon icon)
        {
            TaskbarManager.Instance.SetOverlayIcon(icon, "icon");
        }

        /// <summary>
        /// method to clear task bar icon
        /// </summary>
        public static void ClearTaskBarIcon()
        {
            TaskbarManager.Instance.SetOverlayIcon(null, string.Empty);
        }
        
        #endregion

    }
}
