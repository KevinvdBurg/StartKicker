// --------------------------------------------------------------------------------------------------------------------
// <copyright file="addreward.aspx.cs" company="StartKicker">
//   
// </copyright>
// <summary>
//   The add reward.
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

    /// <summary>
    /// The add reward page
    /// </summary>
    public partial class addReward : System.Web.UI.Page
    {
        /// <summary>
        /// The administrator.
        /// </summary>
        private Administrator administrator = new Administrator();

        /// <summary>
        /// No Actions on the Page Load
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
        /// It will pass all the data to the Administrator 
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        protected void rew_button_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(Request["projectID"]);

            Rewards thisReward = new Rewards();
            int prevReward;
            if (this.rew_prevreward.Items.Count == 0)
            {
                thisReward = new Rewards(
                    rew_name.Text, 
                    Convert.ToInt32(rew_price.Text), 
                    rew_decr.Text, 
                    rew_ship.Text, 
                    0);
            }
            else
            {
                prevReward = Convert.ToInt32(this.rew_prevreward.SelectedItem.Value);
                thisReward = new Rewards(
                    rew_name.Text, 
                    Convert.ToInt32(rew_price.Text), 
                    rew_decr.Text, 
                    rew_ship.Text, 
                    prevReward);
            }

            if (this.administrator.InsertReward(thisReward, projectID))
            {
                MessageBox.Show(this, "Rewards geinsert");
            }
        }
    }
}