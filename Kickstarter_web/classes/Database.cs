using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using Oracle.DataAccess.Client;

    public class Database
    {
        protected OracleConnection connection = new OracleConnection();
        protected string connectionString = "DATA SOURCE=//fhictora01.fhict.local;PASSWORD=K9k8zLNCo0;USER ID=dbi314159";


        public Database()
        {

        }

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

        public void DisConnect()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
