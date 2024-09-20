using ExpensesSys.Pages.Law;
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
    public partial class Documents : System.Web.UI.Page
    {
        public static string RecID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            DataTable dt = BBAALL.GetAllDocksOrARecID(RecID);
            PageProjectNameLbl.Text = BBAALL.getProjectNameByID(Global.getProjectID()).Rows[0]["Name"].ToString();
            DataGridUsers.DataSource = dt;
            DataGridUsers.DataBind();
            }
        }


        protected void GoToNewItem(object sender, EventArgs e)
        {
            Upload.RecID = RecID;
            Response.Redirect("Upload.aspx");

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

                foreach (DataRow dr in BBAALL.GetFileByDockID(Convert.ToInt32(ID)).Rows)
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

                int ID =Convert.ToInt32(e.CommandArgument.ToString());

                BBAALL.DeleteFile(ID);
                Response.Redirect("Documents.aspx");
            }


        }
    }
}