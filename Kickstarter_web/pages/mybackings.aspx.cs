// --------------------------------------------------------------------------------------------------------------------
// <copyright file="mybackings.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The mybackings.
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
    using System.Web.UI.HtmlControls;

    /// <summary>
    /// The mybackings.
    /// </summary>
    public partial class mybackings : System.Web.UI.Page
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
        }

        /// <summary>
        /// The repeater_ backings_ pre render.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Repeater_Backings_PreRender(object sender, EventArgs e)
        {
            if (Repeater_Backings.Items.Count < 1)
            {
                NoRecords.Text = "<h3>All your backings will be here</h3>";
            }
        }
    }
}