// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBLogin.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   All the DB connections that are needed to login someone in and to get all the relative infromation for a account
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
    /// The Login methods that are needed to log someone in
    /// </summary>
    public class DBLogin : Database
    {
        /// <summary>
        /// It will logs someone in the system
        /// </summary>
        /// <param name="email">
        /// An email 
        /// </param>
        /// <param name="password">
        /// An password
        /// </param>
        /// <returns>
        /// An Account Object if an account is found. Otherwise is wil return null
        /// </returns>
        public Account Login(string email, string password)
        {
            Account newAccount = null;
            int accountID;
            string rights;

            string sql;
            sql =
                "SELECT ACCOUNT_ID, RIGHTS FROM KICKSTARTER_ACCOUNT WHERE EMAIL = LOWER(:email) AND KICKPASSWORD = :password";

            // sql = "SELECT * FROM KICKSTARTER_ACCOUNT;";
            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("email", email.ToLower()));
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

        /// <summary>
        /// Gets all the information from a given account ID
        /// </summary>
        /// <param name="account_id">
        /// The account id that you want the details off
        /// </param>
        /// <param name="rights">
        /// The rights from the Account 
        /// </param>
        /// <returns>
        /// A Account or Admin Object from the givven account ID
        /// </returns>
        public Account GetAccount(int account_id, string rights)
        {
            Account newAccount = null;
            string sql;

            if (rights == "admin")
            {
                sql =
                    "SELECT a.email, a.phone, a.kickname, a.picture, a.biography, a.kicklocation, a.timezone, a.vanity_url, a.rights, ad.kickadmin, ad.workemail, ad.salary, ad.DEPARTMENT FROM KICKSTARTER_ACCOUNT a INNER JOIN KICKSTARTER_ADMIN ad ON a.ACCOUNT_ID = ad.ADMIN_ID WHERE ACCOUNT_ID = :ACCOUNT_ID";
            }
            else
            {
                sql =
                    "SELECT email, phone, kickname, picture, biography, kicklocation, timezone, vanity_url, rights FROM KICKSTARTER_ACCOUNT WHERE ACCOUNT_ID = :ACCOUNT_ID";
            }

            try
            {
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("ACCOUNT_ID", account_id));
                OracleDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    if (rights == "user")
                    {
                        newAccount = new Account(
                            account_id, 
                            Convert.ToString(reader["email"]), 
                            Convert.ToString(reader["phone"]), 
                            Convert.ToString(reader["kickname"]), 
                            Convert.ToString(reader["picture"]), 
                            Convert.ToString(reader["biography"]), 
                            Convert.ToString(reader["kicklocation"]), 
                            Convert.ToString(reader["timezone"]), 
                            Convert.ToString(reader["vanity_url"]));
                    }
                    else if (rights == "admin")
                    {
                        newAccount = new Admin(
                            account_id, 
                            Convert.ToString(reader["email"]), 
                            Convert.ToString(reader["phone"]), 
                            Convert.ToString(reader["kickname"]), 
                            Convert.ToString(reader["picture"]), 
                            Convert.ToString(reader["biography"]), 
                            Convert.ToString(reader["kicklocation"]), 
                            Convert.ToString(reader["timezone"]), 
                            Convert.ToString(reader["vanity_url"]), 
                            Convert.ToString(reader["workemail"]), 
                            Convert.ToDouble(reader["salary"]), 
                            Convert.ToString(reader["DEPARTMENT"]));
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