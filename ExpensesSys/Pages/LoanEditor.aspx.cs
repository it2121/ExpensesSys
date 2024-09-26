using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class LoanEditor : System.Web.UI.Page
    {
        public static string RecID = "";
        public static string RecdirectTo = "";
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (!RecID.Equals(""))
                {
                    DataTable OrEmpTbl = BBAALL.GetLoan(RecID);
                    RecIDTB.Text = RecID;

                    foreach (DataRow dt in OrEmpTbl.Rows)
                    {




                        DateOfInv.Text = dt["DateOfInv"].ToString();
                        Type.Text = dt["Type"].ToString();
                        TotalLoanAmount.Text = dt["TotalLoanAmount"].ToString();



                    }

                    if (DateOfInv.Text.Length == 0) { 
                        DateTime dateTime = DateTime.UtcNow.Date;
                    DateOfInv.Text = dateTime.ToString("dd/MM/yyyy");

                    }

                    int Total = Convert.ToInt32(TotalLoanAmount.Text);
                    int Rec = 0;
                    foreach(DataRow dr in BBAALL.GatAllLoanPaymentOfRecID(RecID).Rows)
                    {
                        Rec += Convert.ToInt32 (dr["PaymentAmount"].ToString());

                    }

                    int Rem = Total - Rec;
                    TotalLoanAmount.Text = MyStringManager.GetNumberWithComas(TotalLoanAmount.Text);


                    RecAmount.Text = MyStringManager.GetNumberWithComas(Rec+"");
                    RemAmount.Text = MyStringManager.GetNumberWithComas(Rem+"");





                    setArabicNumberLabel();


                }

            }


        }

        public void setArabicNumberLabel()
        {

            List<CurrencyInfo> currencies = new List<CurrencyInfo>();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));

            ToWord toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(TotalLoanAmount.Text)), currencies[0]);
            TotalLoanAmountLbl.Text = toWord.ConvertToArabic();


             toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(RecAmount.Text)), currencies[0]);
            RecLbl.Text = toWord.ConvertToArabic();



             toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(RemAmount.Text)), currencies[0]);
            RecLbl.Text = toWord.ConvertToArabic();





        }

        protected void Return(object sender, EventArgs e)
        {



            if (RecdirectTo.Length != 0)
            {
                UnitOverlook.RecID = RecID;
                string temp = RecdirectTo;
                RecdirectTo = "";
                Response.Redirect(temp);

            }
            else
            {

                Response.Redirect("UnitIncome.aspx");

            }

        }
        protected void CreateItem(object sender, EventArgs e)
        {



            if (!RecID.Equals(""))
            {

                BBAALL.UpdateLoan(DateOfInv.Text,Type.Text,Convert.ToInt32(MyStringManager.GetIntFromNumberStringWithComas(TotalLoanAmount.Text)),RecID);
                    
                    //, Convert.ToInt32(MyStringManager.GetIntFromNumberStringWithComas(Total.Text)));



                if (RecdirectTo.Length != 0)
                {
                    UnitOverlook.RecID = RecID;
                    string temp = RecdirectTo;
                    RecdirectTo = "";
                    Response.Redirect(temp);

                }
                else
                {

                    Response.Redirect("UnitIncome.aspx");

                }


            }



        }

    }
}