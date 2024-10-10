using ClosedXML.Excel;
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
    public partial class SelectAndExtract : System.Web.UI.Page
    {
        public static int ProjectID = 0;
        DataTable OriginalTalbe;

        protected void Page_Load(object sender, EventArgs e)
        {
            //GetSearchList
            Main.openPage = "OverView";
            if (!IsPostBack)
            {

                OriginalTalbe = BBAALL.GetSearchList(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();


                var list = OriginalTalbe.Rows.OfType<DataRow>()
                   .Select(dr => dr.Field<string>("رقم_الوحدة")).ToList();
                ChBoxList.DataSource = list;
                ChBoxList.DataBind();


                /*

                                DataGridUsers.DataSource = OriginalTalbe;
                                DataGridUsers.DataBind();*/



            }
        }

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
        protected void ChckedChanged(object sender, EventArgs e)
        {

            CheckBox check = sender as CheckBox;
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + check.Checked + "');", true);
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + check.ToolTip + "');", true);

            if (check.Checked)
            {
                RecIDList.Add(check.ToolTip);
            }
            else
            {
                RecIDList.Remove(check.ToolTip);

            }
        }



        List<string> RecIDList = new List<string>();

        protected void ExportToExcel(object sender, EventArgs e)
        {



            foreach (ListItem itemm in ChBoxList.Items)
            {
                if (itemm.Selected == true)
                {
                    RecIDList.Add(itemm.Text);



                }

            }




            // RecIDList.Clear();

            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + tempGV.Rows.Count + "');", true);

            /*
            foreach (GridViewRow dr in tempGV.Rows)
            {

                CheckBox check = dr.FindControl("CheckFromGrid") as CheckBox;

                if (check.Checked)
                    RecIDList.Add(check.ToolTip);
            }*/
            int index = 0;
            if (RecIDList.Count > 0)
            {
                index = RecIDList.Count - 1;



                DataTable dt = BBAALL.GetUnitReporByRecID(RecIDList.ElementAt(index)).Clone();

                foreach (string st in RecIDList)
                {
                    dt.ImportRow(BBAALL.GetUnitReporByRecID(st).Rows[0]);

                }

                ExportBtnc(dt);


            }


        }
        public static void ExportBtnc(DataTable TableToBeExported)
        {

            string pathandname = HttpRuntime.AppDomainAppPath + "/Images/تقرير.xlsx";


            var wb = new XLWorkbook();
            int sheetCounter = 0;
            DataTable IncomeExTbl = TableToBeExported;
            IncomeExTbl.TableName = "البيانات";
            wb.Worksheets.Add(IncomeExTbl);
            sheetCounter++;





            wb.SaveAs(pathandname);





            byte[] bytes = GetBinaryFile(pathandname);



            System.IO.FileInfo file = new System.IO.FileInfo(pathandname);
            HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + file.Name);
            HttpContext.Current.Response.AddHeader("Content-Length", file.Length.ToString());
            HttpContext.Current.Response.ContentType = "text/plain";
            HttpContext.Current.Response.TransmitFile(file.FullName);
            HttpContext.Current.Response.End();








        }

        public static byte[] GetBinaryFile(string filename)
        {
            byte[] bytes;
            using (FileStream file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                bytes = new byte[file.Length];
                file.Read(bytes, 0, (int)file.Length);
            }
            return bytes;
        }

    }
}