﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ExpensesSys.Pages
{
    public partial class EmpMan : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "ProjMan";

            if (!IsPostBack) {

                DataTable dt = BBAALL.GetEmpOfProject(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0]["Name"].ToString();

                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }
           
        }
        protected void GoToNewItem(object sender, EventArgs e)
        {

            EmpEditor.ProjectID = ProjectID;

            Response.Redirect("EmpEditor.aspx");

        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

             Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            EmpEditor.EmpId = Convert.ToInt32(id.Text);
            EmpEditor.ProjectID = ProjectID;


            Response.Redirect("EmpEditor.aspx");


        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("MainFinance.aspx");



        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update
            //  Label id = DataGridUsers.Rows[e.RowIndex].FindControl("lbl_ID") as Label;
            //  TextBox city = DataGridUsers.Rows[e.RowIndex].FindControl("txt_City") as TextBox;

            //updating the record
            //  BBAALL.EditAmountOfItemsProvided(Convert.ToInt32(id.Text), Convert.ToInt32(city.Text));


            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview
            //  DataGridUsers.EditIndex = -1;
            //Call ShowData method for displaying updated data
            //  showstuff();
        }//
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview
            //  DataGridUsers.EditIndex = -1;
            // showstuff();
        }
    }
}