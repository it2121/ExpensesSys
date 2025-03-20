using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WorkContracts : System.Web.UI.Page
    {
        public static int ProjectID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {


            Main.openPage = "WorkContracts";

            if (!IsPostBack)
            {
                NewBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");

                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());

                DataTable dt = BBAALL.GetAllWorkContractsOFAProject(ProjectID);
                PageProjectNameLbl.Text = BBAALL.getProjectNameByID(ProjectID).Rows[0][0].ToString();
                DataTable finalTbl = dt.Clone();
                finalTbl.Clear();

                dt.Columns.Add("UnitCount", typeof(String));
                dt.Columns.Add("PaidAmount", typeof(String));
                dt.Columns.Add("RemAmount", typeof(String));

                foreach (DataRow dr in dt.Rows)
                    
                {

                    dr["UnitCount"] = BBAALL.getCoutOfUnitsForWorkContracts(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                    dr["PaidAmount"] = BBAALL.GetTotalPaidAmountOfWorkContract(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                    dr["RemAmount"] = BBAALL.GetTotalRemAmountOfWorkContract(Convert.ToInt32(dr["ID"])).Rows[0][0].ToString();
                }


                DataGridUsers.DataSource = dt;
                DataGridUsers.DataBind();



            }

        }


        protected void Return(object sender, EventArgs e)
        {

            Expences.ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
            Response.Redirect("Expences.aspx");



        }


        protected void GoToNewItem(object sender, EventArgs e)
        {


            WorkContractsEditor.ProjectID = ProjectID;

            Response.Redirect("WorkContractsEditor.aspx");

        }

        protected void MyGridView_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            string x = e.CommandName;//returns "Select" for both asp:CommandField columns

            if (x.Equals("GoToUnits"))
            {

                string IDToShare = e.CommandArgument.ToString();




                WorkContractsUnits.ID = Convert.ToInt32(IDToShare);
                WorkContractsUnits.ProjectID = ProjectID;


                Response.Redirect("WorkContractsUnits.aspx");

            }
            else if (x.Equals("GoToContractPaymentsCommand")) {


                string IDToShare = e.CommandArgument.ToString();




                WorkContractsPayments.RecID = Convert.ToInt32(IDToShare);


                Response.Redirect("WorkContractsPayments.aspx");

            }
            if (x.Equals("Docks"))
            {


                string ID = e.CommandArgument.ToString();
                Files.RecordID = Convert.ToInt32(ID);
                Files.redirectTo = "WorkContracts";
                Response.Redirect("Files.aspx");

            }
            if (x.Equals("PrintReport"))
            {


                int ID = Convert.ToInt32(e.CommandArgument.ToString());

                printRecord(ID);




                //  Files.RecordID = Convert.ToInt32( ID);
                // Response.Redirect("Files.aspx");

            }


        }


        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.
            // DataGridUsers.EditIndex = e.NewEditIndex;
            //  showstuff();

            Label id = DataGridUsers.Rows[e.NewEditIndex].FindControl("lbl_ID") as Label;


            WorkContractsEditor.ID = Convert.ToInt32(id.Text);
            WorkContractsEditor.ProjectID = ProjectID;


            Response.Redirect("WorkContractsEditor.aspx");


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
        public void printRecord(int RecID)
        {



            // string filename = HttpRuntime.AppDomainAppPath + "/Images/pdffile.pdf";
            //  string headerpath = HttpRuntime.AppDomainAppPath + "/Images/pdfheader.png";
            export(RecID);


        }
        private static PdfPCell PhraseCellClear(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
        }
        private static PdfPCell PhraseCell(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.BLACK;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 4f;
            cell.PaddingTop = 2f;

            return cell;
        }
        private static PdfPCell PhraseCellHeader(Phrase phrase, int align)
        {
            PdfPCell cell = new PdfPCell(phrase);
            cell.BorderColor = BaseColor.WHITE;
            cell.VerticalAlignment = PdfPCell.ALIGN_TOP;
            cell.HorizontalAlignment = align;
            cell.PaddingBottom = 2f;
            cell.PaddingTop = 0f;
            return cell;
        }

        public void export(int RecID)
        {


            DataTable MatBuyTbl = BBAALL.GetWorkContractByID(RecID);



            foreach (DataRow rrooww in MatBuyTbl.Rows)
            {
                Font NormalFont = FontFactory.GetFont("Arial", 12, Font.NORMAL, BaseColor.BLACK);
                Document doc = new Document(PageSize.A4, 88f, 88f, 90f, 25f);

                BaseFont basefontArabic = BaseFont.CreateFont(System.Web.HttpContext.Current.Server.MapPath("/fonts/times.ttf"), BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                iTextSharp.text.Font f = new iTextSharp.text.Font(basefontArabic, 14);
                iTextSharp.text.Font fcontent = new iTextSharp.text.Font(basefontArabic, 12);
                iTextSharp.text.Font fLarg = new iTextSharp.text.Font(basefontArabic, 16);
                using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
                {
                    //doc = new Document(PageSize.A4, 88f, 88f, 90f, 25f);
                    PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);


                    writer.PageEvent = new PDFFooter();
                    Phrase phrase = null;
                    PdfPCell cell = null;
                    PdfPTable table = null;
                    BaseColor color = null;


                    doc.Open();


                    DateTime localDate = DateTime.Now;


                    string pin = "عقد عمل - " + localDate.ToString("yyyy") + "- ";


                    //table for header (Ref SOP NO, FORM NO and Certificate of Analaysis)



                    table = new PdfPTable(1);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 700f });
                    table.SpacingBefore = 20f;



                    cell = PhraseCellClear(new Phrase(BBAALL.getProjectNameByID(Convert.ToInt32(Session["ProjectID"].ToString())).Rows[0][0].ToString(), fLarg), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.WHITE;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);


                    doc.Add(new Paragraph("\n"));



                    doc.Add(table);




                    var text = writer.PageNumber.ToString();
                    table = new PdfPTable(3);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 300f, 300f, 300f });
                    table.SpacingBefore = 20f;






                    cell = PhraseCell(new Phrase("تاريخ القيد", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);





                    cell = PhraseCell(new Phrase("رقم القيد", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);





                    cell = PhraseCell(new Phrase("نوع القيد", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(MyStringManager.GetDateAfterCheckingFormating(rrooww["ContractDate"].ToString()), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);


                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["ContractNumber"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);










                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["ContractType"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);



                    doc.Add(new Paragraph("\n"));



                    doc.Add(table);








                    //single table to holde Quality Control
                    table = new PdfPTable(1);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 300f });
                    table.SpacingBefore = 20f;




                    cell = PhraseCellHeader(new Phrase("المعلومات", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;



                    table.AddCell(cell);
                    doc.Add(table);




                    table = new PdfPTable(2);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 300f, 300f});
                    table.SpacingBefore = 8f;






                    cell = PhraseCell(new Phrase("الاسم", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);








                    cell = PhraseCell(new Phrase("رقم الهاتف", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




             






                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["NameOfPersonal"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);




            


                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["NumberOfPersonal"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);








                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("الكمية", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);





                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("نوع الوحدة القياسية", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["Quant"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["UnityType"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);








                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("عدد الوحدات القياسية", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("الكلفة للوحدة السكنية او التجارية الواحدة", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);







                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["Feetage"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);



                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["UnitPrice"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);


                    cell = PhraseCellClear(new Phrase("", fLarg), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.WHITE;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);

                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("عدد الوحدات المشمولة", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);


                    cell = PhraseCellClear(new Phrase("", fLarg), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.WHITE;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(BBAALL.getCoutOfUnitsForWorkContracts(Convert.ToInt32(rrooww["ID"])).Rows[0][0].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);







                    doc.Add(new Paragraph("\n"));



                    doc.Add(table);




                    DataTable dt = BBAALL.getAllWorkContractsPayByRecID(RecID);



                    table = new PdfPTable(2);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 500f, 500f });
                    table.SpacingBefore = 20f;




                    cell = PhraseCell(new Phrase("المبلغ الكلي حسب الوحدات المشمولة : " + MyStringManager.GetNumberWithComas(rrooww["TotalCost"].ToString()) + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);



                    cell = PhraseCell(new Phrase("المبلغ الواصل : " + MyStringManager.GetNumberWithComas(BBAALL.GetTotalPaidAmountOfWorkContract(RecID).Rows[0][0].ToString()) + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);

                    cell = PhraseCell(new Phrase("المبلغ المتبقي : " + MyStringManager.GetNumberWithComas((Convert.ToInt32(BBAALL.GetTotalRemAmountOfWorkContract(RecID).Rows[0][0].ToString()) ) + "") + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);



                    cell = PhraseCell(new Phrase("عدد الدفعات المستلمة : " + dt.Rows.Count + "", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);







                    doc.Add(table);


                    if (dt.Rows.Count > 0)
                    {


                        //single table to holde Quality Control
                        table = new PdfPTable(1);
                        table.WidthPercentage = 130;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.SetWidths(new float[] { 300f });
                        table.SpacingBefore = 20f;




                        cell = PhraseCellHeader(new Phrase("الدفعات", f), PdfPCell.ALIGN_CENTER);
                        cell.BackgroundColor = GrayColor.WHITE;
                        cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;



                        table.AddCell(cell);
                        doc.Add(table);


                        table = new PdfPTable(3);
                        table.WidthPercentage = 130;
                        table.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.SetWidths(new float[] { 100f, 450f, 300f });
                        table.SpacingBefore = 10f;


                        cell = PhraseCell(new Phrase("رقم الدفعة", fcontent), PdfPCell.ALIGN_CENTER);
                        cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                        cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        table.AddCell(cell);


                        cell = PhraseCell(new Phrase("مبلغ الدفعة", fcontent), PdfPCell.ALIGN_CENTER);
                        cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                        cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        table.AddCell(cell);



                        cell = PhraseCell(new Phrase("التاريخ", fcontent), PdfPCell.ALIGN_CENTER);
                        cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                        cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                        table.AddCell(cell);




                        int counter = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            counter++;
                            phrase = new Phrase();
                            cell = PhraseCell(new Phrase(counter + "", fcontent), PdfPCell.ALIGN_CENTER);
                            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                            table.AddCell(cell);




                            phrase = new Phrase();
                            cell = PhraseCell(new Phrase(MyStringManager.GetNumberWithComas(row["PaidAmount"].ToString()) + "  دينار عراقي  ", fcontent), PdfPCell.ALIGN_CENTER);
                            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                            table.AddCell(cell);



                            phrase = new Phrase();
                            cell = PhraseCell(new Phrase(MyStringManager.GetDateAfterCheckingFormating(row["Date"].ToString()), fcontent), PdfPCell.ALIGN_CENTER);

                            cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                            table.AddCell(cell);





                        }





                        doc.Add(table);

                    }




                    table = new PdfPTable(1);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 300f });
                    table.SpacingBefore = 20f;

                    doc.Add(new Paragraph("\n"));




                    string datetime = localDate.ToString("MM/dd/yyyy HH:mm");

                    cell = PhraseCellHeader(new Phrase(datetime, fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);
                    doc.Add(table);


                    doc.Close();
                    byte[] bytes = memoryStream.ToArray();
                    memoryStream.Close();
                    Response.Clear();

                    Response.ContentType = "application/pdf";
                    string fnm2 = datetime + "تقرير مواد" + ".pdf";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + fnm2);
                    Response.ContentType = "application/pdf";
                    Response.Buffer = true;
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.BinaryWrite(bytes);
                    Response.End();
                    Response.Close();


                }

            }

        }
    }
}