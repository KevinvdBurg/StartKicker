// --------------------------------------------------------------------------------------------------------------------
// <copyright file="one.master.cs" company="">
//   
// </copyright>
// <summary>
//   The one.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Kickstarter_web.classes;

namespace Kickstarter_web
{
    /// <summary>
    /// The one.
    /// </summary>
    public partial class one : System.Web.UI.MasterPage
    {
        /// <summary>
        /// The administrator.
        /// </summary>
        private Administrator administrator = new Administrator();

        /// <summary>
        /// The page_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Session[myKeys.key_accountID] + string.Empty;
            Console.WriteLine(value);

            if (string.IsNullOrEmpty(value))
            {
                // LogOut();
            }
            else
            {
                Account account = administrator.getAccountDetails(
                    Convert.ToInt32(Session[myKeys.key_accountID]), 
                    Convert.ToString(Session[myKeys.key_rights]));
                menuOpties.InnerHtml = "<li><a href=\"#\">" + account.Name
                                       + "</a></li><li><a href=\"/pages/dashboard.aspx\">Dashboard</a></li>";
            }
        }

        /// <summary>
        /// The btn_login_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void btn_login_Click(object sender, EventArgs e)
        {
            Account User = administrator.Login(tb_login_email.Text, tb_login_password.Text);

            if (User is Admin)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "admin";
                Response.Redirect("/pages/dashboard.aspx");
            }
            else if (User is Account)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "user";
                Console.WriteLine("user");
                Response.Redirect("/pages/dashboard.aspx");
            }
            else
            {
                error_login.Text =
                    "<div class=\"alert alert-danger\" role=\"alert\"><span class=\"glyphicon glyphicon-exclamation-sign\" aria-hidden=\"true\"></span><span class=\"sr-only\">Error:</span>Gegevens zijn niet Correct</div>";

                // Response.Redirect("/index.aspx"); 
            }
        }

        /// <summary>
        /// The log out.
        /// </summary>
        protected void LogOut()
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("/index.aspx");
        }
    }
}