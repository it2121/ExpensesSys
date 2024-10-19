using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        public static string EmpStr = "0";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!RecID.Equals(""))
                {
                    DataTable OrEmpTbl = BBAALL.GetFinanceByRecID(RecID);
                    RecIDTB.Text = RecID;

                    OverseeingOfUnit.Text = RecID;

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
                        FirstWarnDate.Text = dt["FirstWarnDate"].ToString();
                        SecondWarnDate.Text = dt["SecondWarnDate"].ToString();
                        FirstWarnRecDate.Text = dt["FirstWarnRecDate"].ToString();
                        SecondWarnRecDate.Text = dt["SecondWarnRecDate"].ToString();



                        UpdateWarnPanels();

                        Loan.Checked = true;
                        Emp.Checked = true;
                        if (!dt["Emp"].ToString().Equals("1"))
                            Emp.Checked = false;


                        if (!dt["Loan"].ToString().Equals("1"))
                            Loan.Checked = false;


                        NonEmp.Checked = !Emp.Checked;
                        NonLoan.Checked = !Loan.Checked;


                    }
                     DataTable TechinfoTbl = BBAALL.GetTechInfo(RecID);


                    foreach (DataRow dt in TechinfoTbl.Rows)
                    {




                        BuiType.Text = dt["BuiType"].ToString();
                        ComPre.Text = dt["ComPre"].ToString();
                        ComStage.Text = dt["ComStage"].ToString();
                        foreach (DataRow innerdt in BBAALL.GetWeightsByID( Convert.ToInt32( dt["WeightReachedRecordID"].ToString())).Rows)
                        {




                          
                            CompStageVerfied.Text = innerdt["WeightText"].ToString();


                        }

                    }  

                    int precentage = Convert.ToInt32(BBAALL.getComPre(RecID).Rows[0][0].ToString());
                    int ShouldBePaid = Convert.ToInt32(BBAALL.GetWhatShouldBePaidForRecID(RecID).Rows[0]["Cost"].ToString());

                    int PaidFromLoan = 0;
                    foreach(DataRow dr in BBAALL.GatAllLoanPaymentOfRecID(RecID).Rows)
                    {
                        PaidFromLoan += Convert.ToInt32(dr["PaymentAmount"].ToString());
                    }

                    Paid.Text =(Convert.ToInt32( BBAALL.GetPaidAmount(RecID).Rows[0][0].ToString()) + PaidFromLoan ) + "";

                    if (Paid.Text.Length == 0) {
                        Paid.Text = "0";
                    }

                    RemAmount.Text = (Convert.ToInt32(Total.Text) - Convert.ToInt32(Paid.Text)) + "";
                    string neg = "";
                    if ((ShouldBePaid - Convert.ToInt32(Paid.Text)) < 0)
                    {
                        neg = "-";

                    }
                    RemBasedOnPrecentage.Text = (ShouldBePaid - Convert.ToInt32(Paid.Text)) + "";
                    RemBasedOnPrecentageOLD.Text =   (((Convert.ToInt32(Total.Text) *(precentage*0.01)) - Convert.ToInt32(Paid.Text)) + "")  ;


                    RemBasedOnPrecentage.Text = KillEverythingAfteDot(RemBasedOnPrecentage.Text);
                    RemBasedOnPrecentageOLD.Text = KillEverythingAfteDot(RemBasedOnPrecentageOLD.Text);

                   

                    int totaint = Convert.ToInt32(Total.Text);

                    Paid.Text = MyStringManager.GetNumberWithComas(Paid.Text);
                    ProPrice.Text = MyStringManager.GetNumberWithComas(ProPrice.Text);
                    RemAmount.Text = MyStringManager.GetNumberWithComas(RemAmount.Text);
                    RemBasedOnPrecentage.Text = neg + MyStringManager.GetNumberWithComas(RemBasedOnPrecentage.Text);
                    RemBasedOnPrecentageOLD.Text = neg + MyStringManager.GetNumberWithComas(RemBasedOnPrecentageOLD.Text);
                    Paid.Text = MyStringManager.GetNumberWithComas(Paid.Text);
                    Total.Text = MyStringManager.GetNumberWithComas(Total.Text);



                    RemBasedOnPrecentage.ForeColor = !Emp.Checked ? Color.Green : Color.Gray;
                    RemBasedOnPrecentageOLD.ForeColor = Emp.Checked ? Color.Green : Color.Gray;





                    setArabicNumberLabel();

                }

            }


            EditBtn1.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            EditBtn2.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            EditBtn3.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            EditBtn4.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
            


        }

        public string KillEverythingAfteDot(string str) {

            string input = str;
            int index = input.IndexOf(".");
            if (index >= 0)
                input =   input.Substring(0, index);
            return input;
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

            toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(RemBasedOnPrecentageOLD.Text)), currencies[0]);
            RemPrecLblOLD.Text = toWord.ConvertToArabic();

            toWord = new ToWord(Convert.ToDecimal(MyStringManager.GetIntFromNumberStringWithComas(ProPrice.Text)), currencies[0]);
            ProPriceLbl.Text = toWord.ConvertToArabic();




        }


        protected void Return(object sender, EventArgs e)
        {
            Response.Redirect("UnitSearch.aspx");
        }
        public void UpdateWarnPanels()
        {

            if (Warn.Text.Equals("بلا انذار"))
            {
                FirstWarnPanel.Visible = false;
                SecondWarnPanel.Visible = false;
            }
            else if (Warn.Text.Equals("انذار اولي"))
            {
                FirstWarnPanel.Visible = true;
                SecondWarnPanel.Visible = false;
            }
            else if (Warn.Text.Equals("انذار نهائي"))
            {
                FirstWarnPanel.Visible = true;
                SecondWarnPanel.Visible = true;
            }

        }
        protected void GoToUnitPayments(object sender, EventArgs e)
        {
            UnitPayments.RecID = RecID;
            UnitPayments.RecdirectTo = "UnitOverlook.aspx";
                Response.Redirect("UnitPayments.aspx");
        }  
        
        protected void GoToTechInfo(object sender, EventArgs e)
        {
            TechInfoEditor.RecID = RecIDTB.Text;
            TechInfoEditor.RecdirectTo = "UnitOverlook.aspx";
            Response.Redirect("TechInfoEditor.aspx");
        }   protected void GoToLoan(object sender, EventArgs e)
        {
            LoanEditor.RecID = RecID;
            LoanEditor.RecdirectTo = "UnitOverlook.aspx";
            Response.Redirect("LoanEditor.aspx");
        } protected void GoToFinance(object sender, EventArgs e)
        {
            FinanceEditor.RecID = RecID;
            FinanceEditor.RecdirectTo = "UnitOverlook.aspx";
            Response.Redirect("FinanceEditor.aspx");
        }     protected void GoToGenralInfo(object sender, EventArgs e)
        {
            GeneralInfoEditor.RecID = RecID;
            GeneralInfoEditor.RecdirectTo = "UnitOverlook.aspx";
            Response.Redirect("GeneralInfoEditor.aspx");
        }  
        
        
        protected void GoToLoanPayments(object sender, EventArgs e)
        {
            LoanPayments.RecID = RecID;
            LoanPayments.RecdirectTo = "UnitOverlook.aspx";
            Response.Redirect("LoanPayments.aspx");
        }
    }
}