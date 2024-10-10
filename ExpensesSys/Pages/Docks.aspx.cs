using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages.Law
{
    public partial class Docks : System.Web.UI.Page
    {
        public static string RecID = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = BBAALL.GetAllDocksOrARecID(RecID);
            PageProjectNameLbl.Text = BBAALL.getProjectNameByID(Convert.ToInt32(Session["ProjectID"].ToString())).Rows[0]["Name"].ToString();
            DataGridUsers.DataSource = dt;
            DataGridUsers.DataBind();

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
                Response.Clear();
                Response.ContentType = sMineType;

                Response.AppendHeader("Content-Disposition", "attachment; filename=" + filenameONLY);
                Response.TransmitFile(filename);
                Response.End();

            }


        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            int IntID = Convert.ToInt32(id.Text);
            // DownloadItem(IntID);


            // ErrorOutput(byteArray.Count() + " Bytes in the file.");
            // System.Web.HttpResponse res = HttpContext.Current.Response;
       /*     Response.Clear();
            Response.ContentType = sMineType;

            Response.AppendHeader("Content-Disposition", "attachment; filename=" + filenameONLY);
            Response.TransmitFile(filename);
            Response.End();
*/

        }

        protected void DownloadItem(int id )
        {
            // NewProv.ProvID = Convert.ToInt32(((Button)sender).ToolTip);
            //  NewProv.AllMasters = BBAALL.GetAllMasters();


            //  DataTable dt = BBAALL.GetFR(Convert.ToInt32(((Button)sender).ToolTip));

            //  GeneratePDF(dt);

            byte[] bytes;
            string fileName;

            DataTable DT = BBAALL.GetFileByDockID(id);


            if (DT.Rows[0]["Doc"].ToString().Length > 0)
            {
                string mimeType = MimeMapping.GetMimeMapping(DT.Rows[0]["DocName"].ToString());

                HttpContext.Current.Response.Clear();
                HttpContext.Current.Response.ClearHeaders();
                HttpContext.Current.Response.ClearContent();
                HttpContext.Current.Response.ContentType = mimeType;


                HttpContext.Current.Response.BufferOutput = true;
                HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment; filename=" + DT.Rows[0]["DocName"].ToString());

                HttpContext.Current.Response.BinaryWrite((byte[])DT.Rows[0]["Doc"]);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();



            }
            else
            {

                ClientScript.RegisterStartupScript(this.GetType(), "Alert ! ", "alert('PDF is not Uploaded yet.');", true);
            }
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