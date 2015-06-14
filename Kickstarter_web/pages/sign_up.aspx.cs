// --------------------------------------------------------------------------------------------------------------------
// <copyright file="sign_up.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The sign_up.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kickstarter_web.pages
{
    using System.Threading;

    /// <summary>
    /// The sign_up.
    /// </summary>
    public partial class sign_up : System.Web.UI.Page
    {
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

        }

        /// <summary>
        /// The regi_button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void regi_button_Click(object sender, EventArgs e)
        {
            Account regiAccount = new Account(0, regi_email.Text, regi_tele.Text, regi_name.Text, string.Empty, regi_bio.Text, regi_loc.Text, regi_tijd.Text, regi_url.Text);

            if (administrator.RegisteerAccount(regiAccount, regi_wachtwoord.Text))
            {
                message.Text = "<p class=\"bg-success\"><br/>Registeren gelukt<br/></p>";
                Response.Redirect("/index.aspx");  
            }
            else
            {
                message.Text = "<p class=\"bg-danger\"><br/>Registeren er is iets fout gegaan<br/></p>";
            }
            
        }
    }
}