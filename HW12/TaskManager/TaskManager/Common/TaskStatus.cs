using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Common
{
    /// <summary>
    /// enum for task status
    /// </summary>
    public enum TaskStatus
    {
        Unresolved,
        Processing,
        Waiting,       
        Completed
    }
}
