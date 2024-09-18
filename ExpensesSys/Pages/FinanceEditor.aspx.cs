using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class FinanceEditor : System.Web.UI.Page
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
                    DataTable OrEmpTbl = BBAALL.GetFinanceByRecID(RecID);
                    RecIDTB.Text = RecID;

                    foreach (DataRow dt in OrEmpTbl.Rows)
                    {




                        Total.Text = dt["Total"].ToString();
                       


                    }
                    int precentage = Convert.ToInt32(BBAALL.getComPre(RecID).Rows[0][0].ToString());
                    int ShouldBePaid = Convert.ToInt32(BBAALL.GetWhatShouldBePaidForRecID(RecID).Rows[0]["Cost"].ToString());

                    Paid.Text =BBAALL.GetPaidAmount(RecID).Rows[0][0].ToString();

                    RemAmount.Text =(Convert.ToInt32(Total.Text) - Convert.ToInt32(Paid.Text) )+"";

                    string neg = "";
                    if((ShouldBePaid - Convert.ToInt32(Paid.Text)) < 0)
                    {
                        neg = "-";

                    }
                    RemBasedOnPrecentage.Text = (ShouldBePaid - Convert.ToInt32(Paid.Text))+"" ;
                    Precantage.Text = BBAALL.GetWhatShouldBePaidForRecID(RecID).Rows[0]["WeightText"].ToString();

                    


                    int totaint = Convert.ToInt32(Total.Text);
                  



                    Paid.Text = MyStringManager.GetNumberWithComas(Paid.Text);
                    RemAmount.Text = MyStringManager.GetNumberWithComas(RemAmount.Text);
                    RemBasedOnPrecentage.Text = neg+ MyStringManager.GetNumberWithComas(RemBasedOnPrecentage.Text);
                    Paid.Text = MyStringManager.GetNumberWithComas(Paid.Text);
                    Total.Text = MyStringManager.GetNumberWithComas(Total.Text);


                    setArabicNumberLabel();


                }

            }

        }
        public void setArabicNumberLabel()
        {

            List<CurrencyInfo> currencies = new List<CurrencyInfo>();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
          
            ToWord toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(Total.Text)), currencies[0]);
            TotalLbl.Text = toWord.ConvertToArabic();
          
             toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(Paid.Text)), currencies[0]);
            PaidLbl.Text = toWord.ConvertToArabic();

             toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(RemAmount.Text)), currencies[0]);
            RemLbl.Text = toWord.ConvertToArabic();

             toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(RemBasedOnPrecentage.Text)), currencies[0]);
            RemPrecLbl.Text = toWord.ConvertToArabic();




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

                BBAALL.UpdateTotalPrice( RecID, Convert.ToInt32( MyStringManager.GetIntFromNumberStringWithComas( Total.Text)));


                Response.Redirect("UnitIncome.aspx");



            }



        }

    }
}