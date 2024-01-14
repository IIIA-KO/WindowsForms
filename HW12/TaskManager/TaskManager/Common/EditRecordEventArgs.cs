using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class EditRecordEventArgs : EventArgs
    {

        #region Data Members

        private int _recordID = 0;

        #endregion

        #region Constructor

        /// <summary>
        /// one argument constructor
        /// </summary>
        /// <param name="recordID">record id</param>
        public EditRecordEventArgs(int recordID)
            : base()
        {
            _recordID = recordID;
        }

        #endregion

        #region Properties

        /// <summary>
        /// get record id
        /// </summary>
        public int RecordID
        {
            get { return _recordID; }
            //set { _recordID = value; }
        }

        #endregion

    }
}
