// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LoggedIn.master.cs" company="">
//   
// </copyright>
// <summary>
//   The logged in.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Kickstarter_web.classes;

namespace Kickstarter_web.masters
{
    /// <summary>
    /// The logged in.
    /// </summary>
    public partial class LoggedIn : System.Web.UI.MasterPage
    {
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

            if (string.IsNullOrEmpty(value))
            {
                LogOut();
            }
            else
            {
                a_log_naam.Text = "Dashboard";

                // a_log_naam.Text = "Welkom: " + currentAccount.Name + " - " + Session[myKeys.key_rights];
            }
        }

        /// <summary>
        /// The a_uitloggen_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void a_uitloggen_Click(object sender, EventArgs e)
        {
            LogOut();
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

        /// <summary>
        /// The a_to_dashboard.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void a_to_dashboard(object sender, EventArgs e)
        {
            Response.Redirect("/pages/dashboard.aspx");
        }
    }
}