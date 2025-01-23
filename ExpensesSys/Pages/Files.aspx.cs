using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class Files : System.Web.UI.Page
    {
        public static int RecordID = 0;
        public static string redirectTo = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = BBAALL.GetAllDocksOrARecIDOriginalDB(RecordID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(Convert.ToInt32(Session["ProjectID"].ToString())).Rows[0]["Name"].ToString();
                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();
                AddNewBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات") ;
            }
        }

        protected void Return(object sender, EventArgs e)
        {

            Expences.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());



            Response.Redirect(redirectTo+".aspx");



        }
        protected void GoToNewItem(object sender, EventArgs e)
        {
            DocUp.RecordID = RecordID;
            DocUp.ReturnToPage = "Files";

            Response.Redirect("DocUp.aspx");

        }
        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;


            if (x.Equals("Down"))
            {

                string ID = e.CommandArgument.ToString();

                string filename = "";
                string filenameONLY = "";

                byte[] byteArray = null;

                foreach (DataRow dr in BBAALL.GetFileByDockIDOriginaldB(Convert.ToInt32(ID)).Rows)
                {
                    filename = dr["DocName"].ToString();
                    filenameONLY = Path.GetFileName(filename);
                    byteArray = (byte[])dr["Doc"];

                }

                string sMineType = MimeMapping.GetMimeMapping(filename);



                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.ClearContent();
                HttpContext.Current.Response.ContentType = sMineType;


                HttpContext.Current.Response.BufferOutput = true;
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + filenameONLY);

                HttpContext.Current.Response.BinaryWrite(byteArray);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();


            }
            else if (x.Equals("Delete"))
            {
                int ID = Convert.ToInt32(e.CommandArgument.ToString());
                BBAALL.DeleteFileOriginalDB(ID);
                Response.Redirect("Files.aspx");
            }


        }
    }
}