using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WorkContractsUnits : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        public static int ID = 0;
        public static string RecID = "";
        public static string UnitType = "";
        public static int WeightReachedRecordID = 0;
        //  public static string ForEmp = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "WorkContracts";


            if (!IsPostBack)
            {
                DataTable AllUnitNames = null;

                if (WeightReachedRecordID == 0)
                    AllUnitNames = BBAALL.GetAllUnitsOfAPorject(ProjectID);


                if (WeightReachedRecordID != 0)
                    AllUnitNames = BBAALL.GetAllUnitsOfAPorjectAndAType(ProjectID, UnitType);


                DataTable UnitNamesOfWorkContract = BBAALL.GetUnitsPerContractOfAContract(ID);

                if (WeightReachedRecordID == 0)
                {
                    var list = AllUnitNames.Rows.OfType<DataRow>()
                   .Select(dr => dr.Field<string>("RecID")).ToList();
                    ChBoxList.DataSource = list;


                    ChBoxList.DataBind();

                    if (ID!=0)
                    {
                        foreach (ListItem itemm in ChBoxList.Items)
                            foreach (DataRow dr in UnitNamesOfWorkContract.Rows)
                            {
                                string UnitName = "";

                                foreach (DataRow row in AllUnitNames.Rows)
                                {

                                    if (dr["UnitRecID"].ToString().Equals(row["RecID"].ToString()))
                                    {
                                        UnitName = row["RecID"].ToString();


                                    }
                                }


                                if (itemm.Text.Equals(UnitName))
                                {

                                    itemm.Selected = true;


                                }

                            }
                    }
                }
                else
                {

                    var list = AllUnitNames.Rows.OfType<DataRow>()
                     .Select(dr => dr.Field<string>("NameOfUnit")).ToList();
                    ChBoxList.DataSource = list;
                    ChBoxList.DataBind();





                }








            }


        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID != 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                InsertUnits();

                Response.Redirect("UnitsOfContracts.aspx");

            }

            if (!RecID.Equals(""))
            {

                InsertTechInfoIntoUnits();
                RecID = "";
                WeightReachedRecordID = 0;
                Response.Redirect("PeojectUnit.aspx");


            }



        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("WorkContracts.aspx");



        }
        public void InsertTechInfoIntoUnits()
        {
            DataTable AllUnitNames = BBAALL.GetAllUnitsOfAPorject(ProjectID);


            foreach (ListItem itemm in ChBoxList.Items)
            {
                if (itemm.Selected == true)
                {

                    BBAALL.UpdateTechInfo(TechInfoEditor.BuiTypeG, TechInfoEditor.ComPreG,

                        TechInfoEditor.ComStageG,


                        itemm.Text, ProjectID, WeightReachedRecordID);


                }

            }




        }
        public void InsertUnits()
        {
            DataTable AllUnitNames = BBAALL.GetAllUnitsOfAPorject(ProjectID);


            foreach (ListItem itemm in ChBoxList.Items)
            {
                if (itemm.Selected == true)
                {


                    foreach (DataRow row in AllUnitNames.Rows)
                        if (row["RecID"].ToString().Equals(itemm.Text))
                        {
                            if (BBAALL.CheckIfUnitExistInWorkContract(ID, row["RecID"].ToString()).Rows.Count == 0)
                                BBAALL.InsertIntoUnitToWorkContract(ID, row["RecID"].ToString());

                        }




                }
                else
                {

                    foreach (DataRow row in AllUnitNames.Rows)
                        if (row[1].ToString().Equals(itemm.Text))
                        {
                            if (BBAALL.CheckIfUnitExistInWorkContract(ID, row["RecID"].ToString()).Rows.Count != 0)
                            {
                                BBAALL.DeleteUnitToWorkContract(ID, row["RecID"].ToString());
                            }

                        }



                }
            }




        }

    }
}