// --------------------------------------------------------------------------------------------------------------------
// <copyright file="dashboard.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The dashboard.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Kickstarter_web.classes;

namespace Kickstarter_web.pages
{
    using System.Web.UI.HtmlControls;

    /// <summary>
    /// The dashboard.
    /// </summary>
    public partial class dashboard : Page
    {
        /// <summary>
        /// The current account.
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// The administrator.
        /// </summary>
        Administrator administrator = new Administrator();

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

            var currentAccount = administrator.getAccountDetails((int)this.Session[myKeys.key_accountID], (string)this.Session[myKeys.key_rights]);
            Gebruiker_ID.Text = "<h2>" + currentAccount.Name +"</h2>";
        }

        /// <summary>
        /// The repeater_projects_ item data bound.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Repeater_projects_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }

        /// <summary>
        /// The repeater_projects_ pre render.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Repeater_projects_PreRender(object sender, EventArgs e)
        {
            if (Repeater_projects.Items.Count < 1)
            {
                NoRecords.Text = "<h3>All your backings will be here</h3>";
            }
        }
    }
}