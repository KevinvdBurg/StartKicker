using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kickstarter_web.classes;

namespace Kickstarter_web.masters
{
    public partial class LoggedIn : System.Web.UI.MasterPage
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Session[myKeys.key_accountID] + "";

            if (String.IsNullOrEmpty(value))
            {
                LogOut();
            }
            else
            {
                
                a_log_naam.Text = "Dashboard";
                //a_log_naam.Text = "Welkom: " + currentAccount.Name + " - " + Session[myKeys.key_rights];
            }
        }

        protected void a_uitloggen_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        protected void LogOut()
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("/index.aspx");
        }

        protected void a_to_dashboard(object sender, EventArgs e)
        {
            Response.Redirect("/pages/dashboard.aspx");
        }
    }
}