// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBAccount.cs" company="">
//   
// </copyright>
// <summary>
//   The db account.
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
    /// The db account.
    /// </summary>
    public class DBAccount : Database
    {
        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="account">
        /// The account.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Insert(Account account, string password)
        {
            bool resultaat = false;

            // string sql = "SELECT email, phone, kickname, picture, biography, kicklocation, timezone, vanity_url, rights FROM KICKSTARTER_ACCOUNT WHERE ACCOUNT_ID = :ACCOUNT_ID";
            string sql = "INSERT INTO KICKSTARTER_ACCOUNT(EMAIL, PHONE, KICKPASSWORD, KICKNAME, PICTURE, BIOGRAPHY, KICKLOCATION, TIMEZONE, VANITY_URL, RIGHTS) VALUES (:EMAIL ,:PHONE, :KICKPASSWORD, :KICKNAME,:PICTURE,:BIOGRAPHY,:KICKLOCATION,:TIMEZONE,:VANITY_URL,:RIGHTS)";
            try
            {
                
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
