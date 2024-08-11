using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Expences : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GoToItemsMan(object sender, EventArgs e)
        {

            ItemsMan.ProjectID = ProjectID;
            Response.Redirect("ItemsMan.aspx");

        }
    }
}