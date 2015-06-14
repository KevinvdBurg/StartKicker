// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Database.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   The database connection class. All the connections to the database will go trough here. 
//   This is so there only needs to be one connectionString and if there is a change in the connection you only needs to change this variable
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
    /// The database that makes all the connection to the Database
    /// </summary>
    public class Database
    {
        /// <summary>
        /// The connection object for Oracle.
        /// </summary>
        protected OracleConnection connection = new OracleConnection();

        /// <summary>
        /// The connection string. Change this if you there is a change in the Database
        /// The String is made of the following components
        /// 
        /// Example: "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421"
        /// The Database location       192.168.15.50:1521
        /// The Password                PASSWORD=K9k8zLNCO0
        /// The User ID                 USER ID=dbi292421
        /// </summary>
        protected string connectionString = "DATA SOURCE=//192.168.15.50:1521/fhictora;PASSWORD=K9k8zLNCO0;USER ID=dbi292421";

        /// <summary>
        /// Initializes a new instance of the <see cref="Database"/> class.
        /// </summary>
        public Database()
        {

        }

        /// <summary>
        /// The General Connection method use to connect to the database. If something went wrong it will disconnect automatically
        /// Besure to have a connection to vdi.fhict.nl usign Cisco AnyConnect.
        /// </summary>
        public void Connect()
        {
            try
            {
                this.connection = new OracleConnection();
                this.connection.ConnectionString = connectionString;
                this.connection.Open();
            }
            catch
            {
                this.connection.Close();
            }
        }

        /// <summary>
        /// The same as the Connect() class exept in reverse.
        /// It will disconnect from the database
        /// </summary>
        public void DisConnect()
        {
            this.connection.Close();
            this.connection.Dispose();
        }
    }
}
