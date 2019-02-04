using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    /// <summary>
    /// class specifically used to connect SQL server
    /// </summary>
    public class DapperConnection : IDisposable
    {
        private bool disposed = false;
        private static SqlConnection sqlConnection;

        /// <summary>
        /// Constructor
        /// </summary>
        public DapperConnection()
        {

        }

        /// <summary>
        /// Get Property used for Connection
        /// </summary>
        public static SqlConnection SqlConnection
        {
            get
            {
                if (sqlConnection == null || string.IsNullOrEmpty(sqlConnection.ConnectionString))
                {
                    string connectionString = ConfigurationManager.AppSettings["ConnectionsString"];
                    sqlConnection = new SqlConnection(connectionString);
                }
                return sqlConnection;
            }
        }

        /// <summary>
        /// Disposed unmanaged resources
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Protected implementation of Dispose
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if(disposed)
            {
                return;
            }

            if(disposing)
            {
                try
                {
                    if(sqlConnection != null)
                    {
                        sqlConnection.Dispose();
                    }
                }
                catch 
                {

                    
                }
            }
            disposed = true;
        }
    }
}
