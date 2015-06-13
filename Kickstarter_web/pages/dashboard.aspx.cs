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
        private Account currentAccount;
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var currentAccount = administrator.getAccountDetails((int)this.Session[myKeys.key_accountID], (string)this.Session[myKeys.key_rights]);
            Gebruiker_ID.Text = "<h2>" + currentAccount.Name +"</h2>";
            //string projectString = null;

            //foreach (Project project in dbProject.GetAllProjectsFromAccount(Convert.ToInt32(Session["accountID"])))
            //{
            //    projectString += "<h2 a href=\"\">" + project.Title + "</h2>";
            //    projectString += "<table class=\"table\">";
            //    projectString += "<tr><td width=\"30%\">ShortBlurb</td><td width=\"70%\">" + project.ShortBlurb + "</td></tr>";
            //    projectString += "<tr><td>ProjectDescription</td><td>" + project.ProjectDescription + "</td></tr>";
            //    projectString += "<tr><td>FundingDuration</td><td>" + project.FundingDuration + "</td></tr>";
            //    projectString += "<tr><td>FundingGoal</td><td>" + project.FundingGoal + "</td></tr>";
            //    projectString += "<tr><td>ProjectVideo</td><td>" + project.ProjectVideo + "</td></tr>";
            //    projectString += "<tr><td>Category</td><td>" + project.Category + "</td></tr>";
            //    projectString += "<tr><td>SubCategory</td><td>" + project.SubCategory + "</td></tr>";
            //    projectString += "</table>";
            //    projectString += "<hr />";
            //}

            //myProjects.Text = projectString;
        }
    }
}