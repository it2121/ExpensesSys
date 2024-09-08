using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class TechInfoEditor : System.Web.UI.Page
    {
        public static string RecID = "";
        public static string BuiTypeG = "";
        public static int ComPreG = 0;
        public static int ProjectID = 0;
        public static string ComStageG = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!RecID.Equals(""))
                {
                    DataTable OrEmpTbl = BBAALL.GetTechInfo(RecID);


                    foreach (DataRow dt in OrEmpTbl.Rows)
                    {




                        BuiType.Text = dt["BuiType"].ToString();
                        ComPre.Text = dt["ComPre"].ToString();
                        ComStage.Text = dt["ComStage"].ToString();
                      

                    }



                }

            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("PeojectUnit.aspx");



        }


        protected void SelectAndAdd(object sender, EventArgs e)
        {
        
            if (!RecID.Equals(""))
            {

                BBAALL.UpdateTechInfo(BuiType.Text,Convert.ToInt32(ComPre.Text) , ComStage.Text,RecID, ProjectID);




      BuiTypeG = BuiType.Text;
         ComPreG = Convert.ToInt32(ComPre.Text);
        ComStageG = ComStage.Text;

                WorkContractsUnits.RecID = RecID;
                WorkContractsUnits.ProjectID = ProjectID;
        Response.Redirect("WorkContractsUnits.aspx");

                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);


                /*

                                BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                                    EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID, HiringDate.Text, Termdate);

                                Response.Redirect("OriginalEmp.aspx");*/




            }



        }
        protected void CreateItem(object sender, EventArgs e)
        {
        
            if (!RecID.Equals(""))
            {

                BBAALL.UpdateTechInfo(BuiType.Text,Convert.ToInt32(ComPre.Text) , ComStage.Text,RecID, ProjectID);

                Response.Redirect("PeojectUnit.aspx");

                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);


                /*

                                BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                                    EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID, HiringDate.Text, Termdate);

                                Response.Redirect("OriginalEmp.aspx");*/


            }



        }
    }
}