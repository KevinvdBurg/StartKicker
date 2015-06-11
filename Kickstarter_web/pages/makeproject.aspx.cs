using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kickstarter_web.classes;

namespace Kickstarter_web.pages
{
    public partial class makeproject : System.Web.UI.Page
    {
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void proj_button_Click(object sender, EventArgs e)
        {
            Project newProject = new Project(proj_title.Text,proj_blurb.Text,proj_location.Text,proj_funding_duration.Text,Convert.ToInt32(proj_funding_goal.Text),proj_video.Text,proj_disc.Text,proj_riskcha.Text, proj_category.Text, proj_subcategory.Text);

            if (administrator.CreeerProject(newProject, Convert.ToInt32(Session[myKeys.key_accountID])))
            {
                
            }
        }

        protected void CustomValidatorproj_title_OnServerValidate(object source, ServerValidateEventArgs args)
        {
            Console.WriteLine("In Validator?");

            if (proj_title.Text.Length > 0)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
            
        }
    }
}