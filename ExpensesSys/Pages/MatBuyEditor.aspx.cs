
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;


using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{



    public partial class MatBuyEditor : System.Web.UI.Page
    {
        public static int MatBuyRecId = 0;
        public static int PrintMatBuyRecId = 0;
        public static int ProjectID = 0;
        public static bool PrintDocNow = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (MatBuyRecId != 0)
                {
                    ProvidedQuant.Text = "0";
                    DataTable MatBuyTbl = BBAALL.getMatBuyRecByID(MatBuyRecId);
                    DataTable ProvidedQuantTbl = BBAALL.getProvidedQuantByMatBuyID(MatBuyRecId);
                    ProvidedQuant.Text = ProvidedQuantTbl.Rows[0][0].ToString();

                    DelBtn.Visible = true;



                    foreach (DataRow dt in MatBuyTbl.Rows)
                    {
                        if (MatBuyRecId.Equals(dt[0]))
                        {



                            MatName.Text = dt["MatName"].ToString();
                            Quant.Text = dt["Quant"].ToString();
                            Count.Text = dt["Count"].ToString();
                            MatType.Text = dt["MatType"].ToString();
                            TotalCost.Text = dt["TotalCost"].ToString();
                            RecAmount.Text = dt["RecAmount"].ToString();
                            Buyer.Text = dt["Buyer"].ToString();
                            ContractNumber.Text = dt["ContractNumber"].ToString();
                            ContractDate.Text = dt["ContractDate"].ToString();
                            ContractDate.Text = dt["ContractDate"].ToString();
                            MatUnit.Text = dt["MatUnit"].ToString();
                            NameOfSupplyer.Text = dt["NameOfSupplyer"].ToString();
                            NumberOfSupplyer.Text = dt["NumberOfSupplyer"].ToString();
                            AddressOfSupplyer.Text = dt["AddressOfSupplyer"].ToString();

                            DataTable counttbl = BBAALL.getPayCountByRecID(MatBuyRecId);
                            RecPayCount.Text = "0";
                            if (counttbl.Rows.Count > 0)
                                RecPayCount.Text = counttbl.Rows[0][0].ToString();


                            RemAmount.Text = Convert.ToInt32(TotalCost.Text) - Convert.ToInt32(RecAmount.Text) + "";

                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";

                    Button1.Text = "طباعة وحفط";

                    if (ProvidedQuant.Text.Length > 0)
                    {
                        ProvidedQuantPrice.Text = (Convert.ToInt32(TotalCost.Text) / Convert.ToInt32(Quant.Text)) * Convert.ToInt32(ProvidedQuant.Text) + "";
                    }
                    else
                    {
                        ProvidedQuantPrice.Text = "0";
                        ProvidedQuant.Text = "0";



                    }

                    if (PrintDocNow)
                    {
                        PrintDocNow = false;
                        print(PrintMatBuyRecId);

                    }

                }
                else
                {
                    MatBuyRecId = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة قيد جديد";
                    Button1.Text = "طباعة واضافة";
                    RemAmount.Text = "";
                    RecPayCount.Text = "";

                    MatName.Text = "";
                    Quant.Text = "";
                    Count.Text = "";
                    MatType.Text = "";
                    TotalCost.Text = "";
                    RecAmount.Text = "";
                    MatName.Text = "";
                    MatName.Text = "";
                    Buyer.Text = "";
                    ContractNumber.Text = "";
                    ContractDate.Text = "";
                    ContractDate.Text = "";
                    MatUnit.Text = "";
                    NameOfSupplyer.Text = "";
                    NumberOfSupplyer.Text = "";
                    AddressOfSupplyer.Text = "";
                    DateTime dateTime = DateTime.UtcNow.Date;
                    ContractDate.Text = dateTime.ToString("dd/MM/yyyy");

                }
                if (PrintDocNow)
                {
                    PrintDocNow = false;
                    print(PrintMatBuyRecId);

                    PrintMatBuyRecId = 0;


                }
                CreateBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                Button1.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                DelBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            }
            else
            {

                if (PrintDocNow)
                {
                    PrintDocNow = false;
                   // print(PrintMatBuyRecId);

                }
            }

        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("MatBuy.aspx");



        }

        protected void PrintAndCreate(object sender, EventArgs e)
        {

            if (MatBuyRecId == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertMatBuy(MatName.Text,
                    Convert.ToInt32(Quant.Text),
                    Convert.ToInt32(Count.Text),
                    MatType.Text,
                                        Convert.ToInt32(TotalCost.Text),

                    ProjectID,
                    "", Buyer.Text,

                                        ContractNumber.Text,
                    ContractDate.Text, MatUnit.Text, NameOfSupplyer.Text, NumberOfSupplyer.Text, AddressOfSupplyer.Text
                    );

                int IIDD = Convert.ToInt32(BBAALL.GetLastAddedMatBuyRecord().Rows[0]["ID"].ToString());
                PrintMatBuyRecId = IIDD;
                MatBuyRecId = IIDD;
                PrintDocNow = true;

                print(IIDD);

                //  MatBuy.print = true;
                //  MatBuy.printID = Convert.ToInt32(BBAALL.GetLastAddedMatBuyRecord().Rows[0]["ID"].ToString());
                // Response.Redirect("MatBuy.aspx");
                Server.TransferRequest(Request.Url.AbsolutePath, false);


            }
            else
            {


                BBAALL.UpdaeMatBuy(MatName.Text,
                    Convert.ToInt32(Quant.Text),
                    Convert.ToInt32(Count.Text),
                    MatType.Text,
                                        Convert.ToInt32(TotalCost.Text),

                    ProjectID,
                     "", Buyer.Text, MatBuyRecId,

                                        ContractNumber.Text,
                    ContractDate.Text, MatUnit.Text, NameOfSupplyer.Text, NumberOfSupplyer.Text, AddressOfSupplyer.Text




                    );
                int temp = MatBuyRecId;
                MatBuyRecId = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد شراء جديد";

                // print(temp);
                int IIDD = Convert.ToInt32(BBAALL.GetLastAddedMatBuyRecord().Rows[0]["ID"].ToString());
                PrintMatBuyRecId = IIDD;
                MatBuyRecId = IIDD;
                PrintDocNow = true;

                print(IIDD);

                // MatBuy.print = true;
                // MatBuy.printID = temp;

                //  Response.Redirect("MatBuy.aspx");
                Server.TransferRequest(Request.Url.AbsolutePath, false);

            }







        }




        public void print(int RecID)
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


            DataTable MatBuyTbl = BBAALL.getMatBuyRecByID(RecID);



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


                    string pin = "تجهيز مواد - " + localDate.ToString("yyyy") + "- ";


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
                    cell = PhraseCell(new Phrase("تجهيز مواد", fcontent), PdfPCell.ALIGN_CENTER);

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




                    table = new PdfPTable(4);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 400f, 300f, 300f, 400f });
                    table.SpacingBefore = 8f;






                    cell = PhraseCell(new Phrase("اسم المجهز", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;


                    table.AddCell(cell);





                    cell = PhraseCell(new Phrase("نوع التجهيز", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);





                    cell = PhraseCell(new Phrase("رقم الهاتف", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("المشتري", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);







                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["NameOfSupplyer"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["MatType"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);



                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["NumberOfSupplyer"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);



                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["Buyer"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);







                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("اسم المادة", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);





                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("الكمية", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);


                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("العدد", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);

                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase("الوحدة", fcontent), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;

                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["MatName"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);




                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["Quant"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);



                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["Count"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);



                    phrase = new Phrase();
                    cell = PhraseCell(new Phrase(rrooww["MatUnit"].ToString(), fcontent), PdfPCell.ALIGN_CENTER);
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

                    table.AddCell(cell);








                    doc.Add(new Paragraph("\n"));



                    doc.Add(table);




                    DataTable dt = BBAALL.getAllPayByRecID(MatBuyRecId);



                    table = new PdfPTable(2);
                    table.WidthPercentage = 130;
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.SetWidths(new float[] { 500f, 500f });
                    table.SpacingBefore = 20f;




                    cell = PhraseCell(new Phrase("المبلغ الكلي : " + MyStringManager.GetNumberWithComas(rrooww["TotalCost"].ToString()) + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);



                    cell = PhraseCell(new Phrase("المبلغ الواصل : " + MyStringManager.GetNumberWithComas(rrooww["RecAmount"].ToString()) + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
                    cell.BackgroundColor = GrayColor.LIGHT_GRAY;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.BackgroundColor = GrayColor.WHITE;
                    cell.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                    cell.FixedHeight = 25f;
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
                    table.AddCell(cell);

                    cell = PhraseCell(new Phrase("المبلغ المتبقي : " + MyStringManager.GetNumberWithComas((Convert.ToInt32(rrooww["TotalCost"].ToString()) - Convert.ToInt32(rrooww["RecAmount"].ToString())) + "") + "  دينار عراقي  ", f), PdfPCell.ALIGN_CENTER);
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

        protected void CreateItem(object sender, EventArgs e)
        {
            if (MatBuyRecId == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertMatBuy(MatName.Text,
                    Convert.ToInt32(Quant.Text),
                    Convert.ToInt32(Count.Text),
                    MatType.Text,
                                        Convert.ToInt32(TotalCost.Text),

                    ProjectID,
                    "", Buyer.Text,

                                        ContractNumber.Text,
                    ContractDate.Text, MatUnit.Text, NameOfSupplyer.Text, NumberOfSupplyer.Text, AddressOfSupplyer.Text
                    );




                Response.Redirect("MatBuy.aspx");

            }
            else
            {


                BBAALL.UpdaeMatBuy(MatName.Text,
                    Convert.ToInt32(Quant.Text),
                    Convert.ToInt32(Count.Text),
                    MatType.Text,
                                        Convert.ToInt32(TotalCost.Text),

                    ProjectID,
                     "", Buyer.Text, MatBuyRecId,

                                        ContractNumber.Text,
                    ContractDate.Text, MatUnit.Text, NameOfSupplyer.Text, NumberOfSupplyer.Text, AddressOfSupplyer.Text




                    );

                MatBuyRecId = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد شراء جديد";


                Response.Redirect("MatBuy.aspx");
            }


        }

        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteMatBuy(MatBuyRecId);
            MatBuyRecId = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد شراء جديد";
            Button1.Text = "طباعة واضافة";


            RemAmount.Text = "0";
            RecPayCount.Text = "0";

            MatName.Text = "";
            Quant.Text = "";
            Count.Text = "";
            MatType.Text = "";
            TotalCost.Text = "";
            RecAmount.Text = "";
            MatName.Text = "";
            MatName.Text = "";
            Buyer.Text = "";


            Response.Redirect("MatBuy.aspx");



        }
    
    
    
    
    }
}