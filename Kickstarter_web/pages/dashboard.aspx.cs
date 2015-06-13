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

    public partial class dashboard : Page
    {
        private Account currentAccount;
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {

            var currentAccount = administrator.getAccountDetails((int)this.Session[myKeys.key_accountID], (string)this.Session[myKeys.key_rights]);
            Gebruiker_ID.Text = "<h2>" + currentAccount.Name +"</h2>";
        }

        protected void Repeater_projects_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            
        }

        protected void Repeater_projects_PreRender(object sender, EventArgs e)
        {
            if (Repeater_projects.Items.Count < 1)
            {
                NoRecords.Text = "<h3>All your backings will be here</h3>";
            }
        }
    }
}