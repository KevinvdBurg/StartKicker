using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kickstarter_web.pages
{
    using System.Threading;

    public partial class sign_up : System.Web.UI.Page
    {
        Administrator administrator = new Administrator();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void regi_button_Click(object sender, EventArgs e)
        {
            Account regiAccount = new Account(0, regi_email.Text, regi_tele.Text, regi_name.Text,"", regi_bio.Text, regi_loc.Text, regi_tijd.Text, regi_url.Text);

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