using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kickstarter_web.pages
{
    using Kickstarter_web.classes;

    public partial class project : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["projectID"];
        }

        protected void backProject(object sender, EventArgs e)
        {
            string id = Request["projectID"];
            int accountID = Convert.ToInt32(Session[myKeys.key_accountID]);
            int backamount = 0;
            
            foreach (RepeaterItem item in Repeater_aproject.Items)
            {
                TextBox txtName = (TextBox)item.FindControl("BackValue");
                if (txtName != null)
                {
                    backamount = Convert.ToInt32(txtName.Text);
                    MessageBox.Show(this, id + "   " + accountID + "  " + backamount);
                }
                else
                {
                    MessageBox.Show(this,"Plegde Amount can't be 0");
                }
            }    
        }
    }
}