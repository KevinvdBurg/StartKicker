using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kickstarter_web.pages
{
    using System.Web.UI.HtmlControls;

    public partial class mybackings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Repeater_Backings_PreRender(object sender, EventArgs e)
        {
            if (Repeater_Backings.Items.Count < 1)
            {
                NoRecords.Text = "<h3>All your backings will be here</h3>";
            }
        }
    }
}