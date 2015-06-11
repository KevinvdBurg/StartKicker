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
        private Account currentAccount;
        Administrator administrator = new Administrator();

        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Session[myKeys.key_accountID] + "";
            Console.WriteLine(value);

            if (String.IsNullOrEmpty(value))
            {
                LogOut();
            }
            else
            {
                currentAccount = administrator.getAccountDetails((int)Session[myKeys.key_accountID], (string)Session[myKeys.key_rights]);
                a_log_naam.Text = "Welkom: " + currentAccount.Name + " - " + Session[myKeys.key_rights];
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
    }
}