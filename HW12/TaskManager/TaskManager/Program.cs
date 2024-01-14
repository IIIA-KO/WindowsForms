using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using TaskManager.Common;

namespace TaskManager
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            #region Check Windows 7

            if (!Microsoft.WindowsAPICodePack.Taskbar.TaskbarManager.IsPlatformSupported)
            {
                MessageBox.Show("This program required Window's 7 to run.", "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            
            //AppDomain.CurrentDomain.SetData(""  
            using (SingleInstanceChecker singleInstance = new SingleInstanceChecker("TaskManager"))
            {

                if (!singleInstance.IsSingle)
                {
                    HandleJumpListCommand();
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    TaskManagerMainForm taskManagerMainForm = new TaskManagerMainForm();

                    Application.Run(taskManagerMainForm);
                }
            }
        }

        /// <summary>
        /// Handle jump list command
        /// </summary>
        private static void HandleJumpListCommand()
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 0)
            {
                int taskID = Convert.ToInt32(args[1]);
                IntPtr wParam = new IntPtr(taskID);

                WindowMessageHelper.SendJumpListCommandForTask(WindowMessageHelper.JumplistEvent, wParam, IntPtr.Zero);

            }
        }

    }
}
