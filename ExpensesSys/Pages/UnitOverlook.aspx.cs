using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class UnitOverlook : System.Web.UI.Page
    {
        public static string RecID = "";
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
                    DataTable GITbl = BBAALL.GetGeneralInfo(RecID);


                    foreach (DataRow dt in GITbl.Rows)
                    {




                        FullName.Text = dt["FullName"].ToString();
                        PhoneNumber.Text = dt["PhoneNumber"].ToString();
                        UniNumAndCat.Text = dt["UniNumAndCat"].ToString();
                        ProNum.Text = dt["ProNum"].ToString();
                        BuildArea.Text = dt["BuildArea"].ToString();
                        ProPrice.Text = dt["ProPrice"].ToString();
                        Address.Text = dt["Address"].ToString();
                        UniArea.Text = dt["UniArea"].ToString();
                        GINote.Text = dt["GINote"].ToString();
                        Warn.Text = dt["Warn"].ToString();
                        Loan.Checked = true;
                        Emp.Checked = true;
                        if (!dt["Emp"].ToString().Equals("1"))
                            Emp.Checked = false;

                        if (!dt["Loan"].ToString().Equals("1"))
                            Loan.Checked = false;


                    }
                     DataTable TechinfoTbl = BBAALL.GetTechInfo(RecID);


                    foreach (DataRow dt in TechinfoTbl.Rows)
                    {




                        BuiType.Text = dt["BuiType"].ToString();
                        ComPre.Text = dt["ComPre"].ToString();
                        ComStage.Text = dt["ComStage"].ToString();
                      

                    }


                    int precentage = Convert.ToInt32(BBAALL.getComPre(RecID).Rows[0][0].ToString());

                    Paid.Text = BBAALL.GetPaidAmount(RecID).Rows[0][0].ToString();

                    RemAmount.Text = (Convert.ToInt32(Total.Text) - Convert.ToInt32(Paid.Text)) + "";
                    RemBasedOnPrecentage.Text = (Convert.ToInt32(Total.Text) * (precentage * 0.01) - Convert.ToInt32(Paid.Text)) + "";
                   // Precantage.Text = BBAALL.getComPre(RecID).Rows[0][0].ToString() + " %";

                    int totaint = Convert.ToInt32(Total.Text);




                    Paid.Text = MyStringManager.GetNumberWithComas(Paid.Text);
                    ProPrice.Text = MyStringManager.GetNumberWithComas(ProPrice.Text);
                    RemAmount.Text = MyStringManager.GetNumberWithComas(RemAmount.Text);
                    RemBasedOnPrecentage.Text = MyStringManager.GetNumberWithComas(RemBasedOnPrecentage.Text);
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

            toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(ProPrice.Text)), currencies[0]);
            ProPriceLbl.Text = toWord.ConvertToArabic();




        }


        protected void Return(object sender, EventArgs e)
        {

            
            Response.Redirect("UnitSearch.aspx");



        }
        protected void GoToUnitPayments(object sender, EventArgs e)
        {



            UnitPayments.RecID = RecID;

                Response.Redirect("UnitPayments.aspx");

            
        }  
        
        protected void GoToTechInfo(object sender, EventArgs e)
        {



            TechInfoEditor.RecID = RecID;

                Response.Redirect("TechInfoEditor.aspx");

            
        }   protected void GoToFinance(object sender, EventArgs e)
        {



            FinanceEditor.RecID = RecID;

                Response.Redirect("FinanceEditor.aspx");

            
        }     protected void GoToGenralInfo(object sender, EventArgs e)
        {



            GeneralInfoEditor.RecID = RecID;

                Response.Redirect("GeneralInfoEditor.aspx");

            
        }  
        
        
        protected void GoToLoanPayments(object sender, EventArgs e)
        {



           

                Response.Redirect("UnitIncome.aspx");



            



        }
    }
}