// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBAccount.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   This class is used to create a account that is used for the Website.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

using Oracle.DataAccess.Client;

namespace Kickstarter_web
{
    /// <summary>
    /// A Connection to the Database to Select, Insert, Update or Delete a record(s)
    /// </summary>
    public class DBAccount : Database
    {
        /// <summary>
        /// A insert Method that creates an account
        /// </summary>
        /// <param name="account">
        /// A Account Object that stores all the details for that account
        /// </param>
        /// <param name="password">
        /// The password for the New Account
        /// </param>
        /// <returns>
        /// Returns True or False Depending on if it succeeds
        /// </returns>
        public bool Insert(Account account, string password)
        {
            bool resultaat = false;

            string sql = "INSERT INTO KICKSTARTER_ACCOUNT(EMAIL, PHONE, KICKPASSWORD, KICKNAME, PICTURE, BIOGRAPHY, KICKLOCATION, TIMEZONE, VANITY_URL, RIGHTS) VALUES (:EMAIL ,:PHONE, :KICKPASSWORD, :KICKNAME,:PICTURE,:BIOGRAPHY,:KICKLOCATION,:TIMEZONE,:VANITY_URL,:RIGHTS)";
            try
            {
                //Connects to the Database class
                this.Connect();
                OracleCommand cmd = new OracleCommand(sql, this.connection);
                cmd.Parameters.Add(new OracleParameter("EMAIL",  account.Email.ToLower()));
                cmd.Parameters.Add(new OracleParameter("PHONE", account.Phone));
                cmd.Parameters.Add(new OracleParameter("KICKPASSWORD", password));
                cmd.Parameters.Add(new OracleParameter("KICKNAME", account.Name));
                cmd.Parameters.Add(new OracleParameter("PICTURE", account.Picture));
                cmd.Parameters.Add(new OracleParameter("BIOGRAPHY", account.Biography));
                cmd.Parameters.Add(new OracleParameter("KICKLOCATION", account.Location));
                cmd.Parameters.Add(new OracleParameter("TIMEZONE", account.TimeZone));
                cmd.Parameters.Add(new OracleParameter("VANITY_URL", account.Vanity_URL));
                cmd.Parameters.Add(new OracleParameter("RIGHTS", "user"));

                resultaat = true;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                this.connection.Close();
            }

            return resultaat;
        }
    }
}
