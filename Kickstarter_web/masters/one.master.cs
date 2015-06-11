using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kickstarter_web.classes;

namespace Kickstarter_web
{
    public partial class one : System.Web.UI.MasterPage
    {
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Account User = administrator.Login(tb_login_email.Text, tb_login_password.Text);

            if (User is Admin)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "admin";
            }
            else if (User is Account)
            {
                Session[myKeys.key_accountID] = User.AccountID;
                Session[myKeys.key_rights] = "user";
                Console.WriteLine("user");
            }

            Response.Redirect("/pages/dashboard.aspx");  
        }
    }
}