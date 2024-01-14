using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace TaskManager.Common
{
    /// <summary>
    /// Class to handle user 32 methods and provide wrapper class for user 32 class
    /// </summary>
    static class WindowMessageHelper
    {

        #region Register user 32 methods

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr l);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern int RegisterWindowMessage(string msgName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        static extern bool SetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);


        private struct POINTAPI
        {
            public int x;
            public int y;
        }

        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public int showCmd;
            public POINTAPI ptMinPosition;
            public POINTAPI ptMaxPosition;
            public RECT rcNormalPosition;
        }
        
        #endregion

        #region Public Data Member

        public static int JumplistEvent;
        
        #endregion

        #region Cosntructor

        static WindowMessageHelper()
        {
            JumplistEvent = RegisterWindowMessage("TaskManager.JumplistEvent");
        }
        
        #endregion

        #region Public Static Methods

        /// <summary>
        /// Send command message for opening task window
        /// </summary>
        /// <param name="messageID">messageID</param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns>true ofr successfully send message to form</returns>
        public static bool SendJumpListCommandForTask(int messageID, IntPtr wParam, IntPtr lParam)
        {
            string[] possibleWindowsTitle = { "Task Manager 1.0", "Task Manager 1.0 - [Task Details]", "Task Manager 1.0 - [Manage Resources]", "Task Manager 1.0 - [Manage Category]", "Task Manager 1.0 - [Gantt]" };
            IntPtr window = IntPtr.Zero;

            foreach (string windowName in possibleWindowsTitle)
            {
                window = FindWindow(null, windowName);
                //System.Windows.Forms.MessageBox.Show(windowName + " : " + window.ToString());    


                if (window != IntPtr.Zero)
                    break;
            }

            if (window == IntPtr.Zero) return false;


            // maximize window
            //// MaximizeWindow(window);

            // Send message to main form
            IntPtr result = SendMessage(window, messageID, wParam, lParam);

            return result == IntPtr.Zero;
        }

        /// <summary>
        /// Maximize window
        /// </summary>
        /// <param name="appHandle">application handle</param>
        public static void MaximizeWindow(IntPtr appHandle)
        {

            WINDOWPLACEMENT wp = new WINDOWPLACEMENT();

            GetWindowPlacement(appHandle, ref wp);
            if (wp.showCmd != 3)
            {
                wp.showCmd = 3; // 1- Normal; 2- Minimize; 3-Maximize;
                SetWindowPlacement(appHandle, ref wp);
            }

        }
        
        #endregion

    }
}
