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
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "WorkContracts";


            if (!IsPostBack) {

                DataTable AllUnitNames = BBAALL.GetAllUnitsOfAPorject(ProjectID);
                DataTable UnitNamesOfWorkContract = BBAALL.GetUnitsPerContractOfAContract(ID);


                var list = AllUnitNames.Rows.OfType<DataRow>()
                   .Select(dr => dr.Field<string>("NameOfUnit")).ToList();
                ChBoxList.DataSource = list;


                ChBoxList.DataBind();


                foreach (ListItem itemm in ChBoxList.Items)
                    foreach (DataRow dr in UnitNamesOfWorkContract.Rows)
                    {
                        string UnitName = "";

                        foreach (DataRow row in AllUnitNames.Rows)
                        {

                            if (dr["UnitRecID"].ToString().Equals(row["NameOfUnit"].ToString()))
                            {
                                UnitName = row["NameOfUnit"].ToString();


                            }
                        }


                        if (itemm.Text.Equals(UnitName))
                        {

                            itemm.Selected = true;


                        }

                    }


            }


        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID != 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                InsertUnits();

                Response.Redirect("WorkContracts.aspx");

            }
          


        }
   
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("WorkContracts.aspx");



        }
        public void InsertUnits()
        {
            DataTable AllUnitNames = BBAALL.GetAllUnitsOfAPorject(ProjectID);


            foreach (ListItem itemm in ChBoxList.Items)
                {
                    if (itemm.Selected == true)
                    {


                        foreach (DataRow row in AllUnitNames.Rows)
                            if (row["NameOfUnit"].ToString().Equals(itemm.Text))
                            {
                                if (BBAALL.CheckIfUnitExistInWorkContract(ID, row["NameOfUnit"].ToString()).Rows.Count == 0)
                                    BBAALL.InsertIntoUnitToWorkContract(ID, row["NameOfUnit"].ToString());

                            }




                    }
                    else
                    {

                        foreach (DataRow row in AllUnitNames.Rows)
                            if (row[1].ToString().Equals(itemm.Text))
                            {
                                if (BBAALL.CheckIfUnitExistInWorkContract(ID, row["NameOfUnit"].ToString()).Rows.Count != 0)
                                {
                                    BBAALL.DeleteUnitToWorkContract(ID, row["NameOfUnit"].ToString());
                                }

                            }
             


                    }
                }
               

            

        }

    }
}