// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Database.cs" company="">
//   
// </copyright>
// <summary>
//   The database.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using Oracle.DataAccess.Client;

    /// <summary>
    /// The database.
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The connection.
        /// </summary>
        protected OracleConnection connection = new OracleConnection();

        /// <summary>
        /// The connection string.
        /// </summary>
        protected string connectionString = "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421";

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {

        }

        /// <summary>
        /// The connect.
        /// </summary>
        public void Connect()
        {
            try
            {
                connection = new OracleConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
            }
            catch
            {
                connection.Close();
            }
        }

        /// <summary>
        /// The dis connect.
        /// </summary>
        public void DisConnect()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
