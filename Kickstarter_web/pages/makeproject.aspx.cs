// --------------------------------------------------------------------------------------------------------------------
// <copyright file="makeproject.aspx.cs" company="">
//   
// </copyright>
// <summary>
//   The makeproject.
// </summary>
// --------------------------------------------------------------------------------------------------------------------





namespace Kickstarter_web.pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    using Kickstarter_web.classes;
    /// <summary>
    /// The makeproject.
    /// </summary>
    public partial class makeproject : System.Web.UI.Page
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

        }

        /// <summary>
        /// The proj_button_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void proj_button_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Category newCategory = new Category(Convert.ToInt32(proj_category.SelectedItem.Value), Convert.ToString(proj_category.SelectedItem.Text));
                Project newProject = new Project(proj_title.Text, proj_blurb.Text, proj_location.Text, proj_funding_duration.Text, Convert.ToInt32(proj_funding_goal.Text), proj_video.Text, proj_disc.Text, proj_riskcha.Text, newCategory, "1", 0);

                if (administrator.CreeerProject(newProject, Convert.ToInt32(Session[myKeys.key_accountID])))
                {
                    MessageBox.Show(this, "Project is aangemaakt");
                }
            }
        }

        /// <summary>
        /// The custom validatorproj_title_ on server validate.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
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