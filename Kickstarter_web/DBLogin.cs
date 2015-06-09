using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Kickstarter_web
{
    using Oracle.DataAccess.Client;

    public class DBLogin : Database
    {
        public Account Login(string email, string password)
        {
            Account newAccount = null;
            int accountID;
            string rights;

            string sql;
            sql = "SELECT ACCOUNT_ID, RIGHTS FROM KICKSTARTER_ACCOUNT WHERE EMAIL = :email AND KICKPASSWORD = :password";
            //sql = "SELECT * FROM KICKSTARTER_ACCOUNT;";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("email", email));
                cmd.Parameters.Add(new OracleParameter("password", password));
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    accountID = Convert.ToInt32(reader["ACCOUNT_ID"]);
                    rights = Convert.ToString(reader["RIGHTS"]);
                    
                    if (rights == "user")
                    {
                        newAccount = new Account(accountID);
                    }
                    else if (rights == "admin")
                    {
                        newAccount = new Admin(accountID);
                    }
                }
            }
            catch (OracleException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                this.connection.Close();
            }

            return newAccount;
        }
    }
}
