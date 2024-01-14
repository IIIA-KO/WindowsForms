using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;

namespace TaskManager.Common
{
    /// <summary>
    /// Class to insure the single instance of the application
    /// </summary>
    public class SingleInstanceChecker : IDisposable
    {

        #region Data Members

        private Mutex _mutex;
        private bool _isNew = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public SingleInstanceChecker()
            : this(string.Empty)
        {
        }

        /// <summary>
        /// Constructor to get process name
        /// </summary>
        /// <param name="name">name of process/application</param>
        public SingleInstanceChecker(string name)
        {
            string mutexName = Assembly.GetExecutingAssembly().GetName().Name + name;
            _mutex = new Mutex(true, mutexName, out _isNew);
        }

        #endregion

        #region Destructor

        /// <summary>
        /// Destructor to release mutex
        /// </summary>
        ~SingleInstanceChecker()
        {
            ReleaseMutex();
        }

        #endregion

        #region Properties

        /// <summary>
        /// get true it is first instance
        /// </summary>
        public bool IsSingle
        {
            get { return _isNew; }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Relase owned mutex
        /// </summary>
        private void ReleaseMutex()
        {
            if (_isNew)
            {
                _mutex.ReleaseMutex();
                _isNew = false;
            }
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// dispose and release mutex
        /// </summary>
        public void Dispose()
        {
            ReleaseMutex();
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}
