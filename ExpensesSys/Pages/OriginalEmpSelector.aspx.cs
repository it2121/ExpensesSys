using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class OriginalEmpSelector : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GoToOriginalEmpAsManagment(object sender, EventArgs e)
        {
            // PeojectSeector.GoToPage = "OriginalEmp";
            OriginalEmp.ProjectID = ProjectID;
            OriginalEmp.InvolvmentType = "ملاك هندسي";
            Response.Redirect("OriginalEmp.aspx");





        }
        protected void GoToOriginalEmpAsEngineering(object sender, EventArgs e)
        {
            OriginalEmp.ProjectID = ProjectID;
            OriginalEmp.InvolvmentType = "ملاك اداري";
            Response.Redirect("OriginalEmp.aspx");





        }
    }
}