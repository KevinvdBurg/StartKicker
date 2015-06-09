using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kickstarter_web.classes;
namespace Kickstarter_web.pages
{
    
    public partial class dashboard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Gebruiker_ID.Text = "Welkom Gebruiker:" + Session["accountID"] + " - " + Session["rights"];
        }
    }
}