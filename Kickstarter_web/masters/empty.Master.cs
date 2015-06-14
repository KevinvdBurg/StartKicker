// --------------------------------------------------------------------------------------------------------------------
// <copyright file="empty.Master.cs" company="">
//   
// </copyright>
// <summary>
//   The empty.
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
    using Kickstarter_web.classes;

    /// <summary>
    /// The empty.
    /// </summary>
    public partial class empty : System.Web.UI.MasterPage
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
    }

    /// <summary>
    /// The message box.
    /// </summary>
    public static class MessageBox
    {
        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="Page">
        /// The page.
        /// </param>
        /// <param name="Message">
        /// The message.
        /// </param>
        public static void Show(this Page Page, string Message)
        {
            Page.ClientScript.RegisterStartupScript(
               Page.GetType(), 
               "MessageBox", 
               "<script language='javascript'>alert('" + Message + "');</script>"
            );
        }
    }
}