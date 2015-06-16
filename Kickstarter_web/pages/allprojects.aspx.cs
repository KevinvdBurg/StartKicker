// --------------------------------------------------------------------------------------------------------------------
// <copyright file="allprojects.aspx.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   The allprojects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Kickstarter_web.pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    using Kickstarter_web.classes;

    using System.Web.UI.HtmlControls;

    /// <summary>
    /// The allprojects.
    /// </summary>
    public partial class allprojects : System.Web.UI.Page
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
            string projectString = null;
            string value = Session[myKeys.key_accountID] + string.Empty;
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
                NoRecords.Text = "<h3>Something went wrong #blameAthena</h3>";
            }
        }
    }
}