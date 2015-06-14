using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kickstarter_web.pages
{
    public partial class addReward : System.Web.UI.Page
    {
        Administrator administrator = new Administrator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rew_button_Click(object sender, EventArgs e)
        {
            int projectID = Convert.ToInt32(Request["projectID"]);

            Rewards thisReward = new Rewards();
            int prevReward;
            if (this.rew_prevreward.Items.Count == 0)
            {
                thisReward = new Rewards(rew_name.Text, Convert.ToInt32(rew_price.Text), rew_decr.Text, rew_ship.Text, 0);
            } 
            else
            {
                prevReward = Convert.ToInt32(this.rew_prevreward.SelectedItem.Value);
                thisReward = new Rewards(rew_name.Text, Convert.ToInt32(rew_price.Text), rew_decr.Text, rew_ship.Text, prevReward);
            }

            if (this.administrator.InsertReward(thisReward, projectID))
            {
                MessageBox.Show(this, "Rewards geinsert");
            }
        }
    }
}