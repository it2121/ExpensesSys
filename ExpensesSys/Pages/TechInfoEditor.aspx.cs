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
        public static string RecdirectTo = "";
        public static int WeightReachedRecordID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!RecID.Equals(""))
                {
                    ProjectID = Global.getProjectID();
                    DataTable OrEmpTbl = BBAALL.GetTechInfo(RecID);
                    DataTable Weights = BBAALL.GetWeightsForUnit(ProjectID, OrEmpTbl.Rows[0]["BuiType"].ToString()
                        );

                   //  ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ProjectID + OrEmpTbl.Rows[0]["BuiType"].ToString() + "');", true);

                    foreach (DataRow row in Weights.Rows)
                    {

                        WeightReachedRecordID_CB.Items.Add(row["WeightText"].ToString());
                        WeightReachedRecordID_CB.Items.FindByText (row["WeightText"].ToString()).Value  = row["ID"].ToString();
                    }  
                  
                    foreach (DataRow dt in OrEmpTbl.Rows)
                    {




                        BuiType.Text = dt["BuiType"].ToString();
                        ComPre.Text = dt["ComPre"].ToString();
                        ComStage.Text = dt["ComStage"].ToString();
                        WeightReachedRecordID =Convert.ToInt32(dt["WeightReachedRecordID"].ToString());
                      WeightReachedRecordID_CB.Items.FindByValue(WeightReachedRecordID+"").Selected = true;

                    }



                }

            }
        }
        protected void Return(object sender, EventArgs e)
        {


            if (RecdirectTo.Length != 0)
            {
                UnitOverlook.RecID = RecID;
                string temp = RecdirectTo;
                RecdirectTo = "";
                Response.Redirect(temp);
            }
            else
            {
                Response.Redirect("PeojectUnit.aspx");
            }


        }


        protected void SelectAndAdd(object sender, EventArgs e)
        {
           

            if (!RecID.Equals(""))
            {
                string WeightID = "0";
                foreach (ListItem item in WeightReachedRecordID_CB.Items)
                {
                    if (item.Selected)
                    {
                        WeightID = item.Value + "";
                    }
                }

                BBAALL.UpdateTechInfo(BuiType.Text,Convert.ToInt32(ComPre.Text) , ComStage.Text,RecID,
                    
                    ProjectID,
                    Convert.ToInt32(WeightID));




      BuiTypeG = BuiType.Text;
         ComPreG = Convert.ToInt32(ComPre.Text);
        ComStageG = ComStage.Text;

                WorkContractsUnits.RecID = RecID;
                WorkContractsUnits.UnitType = BuiType.Text;
                WorkContractsUnits.WeightReachedRecordID = WeightReachedRecordID;
                WorkContractsUnits.ProjectID = ProjectID;
               // WorkContractsUnits.ForEmp = BBAALL.GetGeneralInfo(RecID).Rows[0]["Emp"].ToString();
                Response.Redirect("WorkContractsUnits.aspx");



                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);

            }

        }
        protected void CreateItem(object sender, EventArgs e)
        {
        
            if (!RecID.Equals(""))
            {
                string WeightID = "0";
                foreach (ListItem item in WeightReachedRecordID_CB.Items)
                {
                    if (item.Selected)
                    {
                        WeightID = item.Value + "";
                    }
                }

                BBAALL.UpdateTechInfo(BuiType.Text,Convert.ToInt32(ComPre.Text) , ComStage.Text,RecID, ProjectID,

                    Convert.ToInt32(WeightID));

             //   Response.Redirect("PeojectUnit.aspx");


                if (RecdirectTo.Length != 0)
                {
                    UnitOverlook.RecID = RecID;
                    string temp = RecdirectTo;
                    RecdirectTo = "";
                    Response.Redirect(temp);
                }
                else
                {
                    Response.Redirect("PeojectUnit.aspx");
                }
                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);


                /*

                                BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                                    EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID, HiringDate.Text, Termdate);

                                Response.Redirect("OriginalEmp.aspx");*/


            }



        }
    }
}