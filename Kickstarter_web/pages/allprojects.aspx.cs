﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="allprojects.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The allprojects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



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

    /// <summary>
    /// The allprojects.
    /// </summary>
    public partial class allprojects : System.Web.UI.Page
    {
        /// <summary>
        /// The administrator.
        /// </summary>
        Administrator administrator = new Administrator();

        /// <summary>
        /// The page_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string projectString = null;
            string value = Session[myKeys.key_accountID] + string.Empty;

            // this.AllProjects.;

            /*foreach (Project project in administrator.GetallProject())
            {
                projectString += "<h2>" + project.Title + "</h2>";
                projectString += "<table class=\"table\">";
                projectString += "<tr><td width=\"30%\">ShortBlurb</td><td width=\"70%\">" + project.ShortBlurb + "</td></tr>";
                projectString += "<tr><td>ProjectDescription</td><td>" + project.ProjectDescription + "</td></tr>";
                projectString += "<tr><td>FundingDuration</td><td>" + project.FundingDuration + "</td></tr>";
                projectString += "<tr><td>FundingGoal</td><td>" + project.FundingGoal + "</td></tr>";
                projectString += "<tr><td>ProjectVideo</td><td>" + project.ProjectVideo + "</td></tr>";
                projectString += "<tr><td>Category</td><td>" + project.Category + "</td></tr>";
                projectString += "<tr><td>SubCategory</td><td>" + project.SubCategory + "</td></tr>";
                if (!String.IsNullOrEmpty(value))
                {
                    projectString +=
                        "<tr><td><input type=\"button\" ID=\"project\" runat=\"server\" onclick=\"doTest()\" value=\""
                        + project.ProjectID + "\" /></td><td> <input type=\"number\" ID=\"input\" runat=\"server\"/></td></tr>";
                }
                projectString += "</table>";
                projectString += "<hr />";
            }



            allProjects.Text = projectString;*/
        }

        /// <summary>
        /// The repeater_projects_ pre render.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void Repeater_projects_PreRender(object sender, EventArgs e)
        {
            if (Repeater_projects.Items.Count < 1)
            {
                NoRecords.Text = "<h3>Something went wrong #blameAthena</h3>";
            }
        }
    }
}