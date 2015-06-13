﻿using System;
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
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["projectID"];
        }

        protected void backProject(object sender, EventArgs e)
        {
            
            string projectID = Request["projectID"];
            int accountID = Convert.ToInt32(Session[myKeys.key_accountID]);
            int backamount = 0;

            string value = Session[myKeys.key_accountID] + "";

            if (String.IsNullOrEmpty(value))
            {
                MessageBox.Show(this, "Log eerst in voordat u een Project Backed");
            }
            else
            {
                foreach (RepeaterItem item in Repeater_aproject.Items)
                {
                    TextBox txtName = (TextBox)item.FindControl("BackValue");
                    if (txtName != null)
                    {
                        backamount = Convert.ToInt32(txtName.Text);
                        MessageBox.Show(this, projectID + "   " + accountID + "  " + backamount);
                        this.administrator.BackProject(projectID, accountID, backamount);
                    }

                    else
                    {
                        MessageBox.Show(this,"Plegde Amount can't be 0");
                    }
                }   
            }
             
        }


    }
}