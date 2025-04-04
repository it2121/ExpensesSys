﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class UnitSearch : System.Web.UI.Page
    {
        public static int ProjectID = 0; 
        protected void Page_Load(object sender, EventArgs e)
        {
            //GetSearchList
            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());


                // DataTable dt = BBAALL.GetSearchList(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();

        


                /*DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();*/



            }
        }



        /*      protected void textChanged(object sender, EventArgs e)
              {
                  //NewEditIndex property used to determine the index of the row being edited.
                  // DataGridUsers.EditIndex = e.NewEditIndex;
                  //  showstuff();

                   ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + SearchBox.Text + "');", true);


              }*/

        protected void Return(object sender, EventArgs e)
        {

            if (Session["Role"].Equals("ادارة"))
            {

                Response.Redirect("MainProjMan.aspx");

            }
            else
            {
                Response.Redirect("MainFinance.aspx");
            }






        }
        protected void Search(object sender, EventArgs e)
        {

            DataTable dt = BBAALL.GetSearchListByWord(ProjectID,SearchBox.Text);
            DataGridUsers.DataSource = dt;
            SearchBox.Text = "";
            DataGridUsers.DataBind();

        }
            protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_OR23") as Label;

            Session["RecID"] = id.Text;
           // UnitOverlook.RecID = id.Text;
            UnitOverlook.ProjectID = ProjectID;


            Response.Redirect("UnitOverlook.aspx");


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