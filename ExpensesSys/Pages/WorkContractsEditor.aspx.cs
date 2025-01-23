using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class WorkContractsEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static int ProjectID = 0 ;
        protected void Page_Load(object sender, EventArgs e)
        {
            Main.openPage = "WorkContracts";


            if (!IsPostBack)
            {
              
                if (ID != 0)
                {


                    DataTable CompTbl = BBAALL.GetWorkContractByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in CompTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            ContractNumber.Text = dt["ContractNumber"].ToString();
                            ContractType.Text = dt["ContractType"].ToString();
                            NameOfPersonal.Text = dt["NameOfPersonal"].ToString();
                            NumberOfPersonal.Text = dt["NumberOfPersonal"].ToString();
                            AddressOfPersonal.Text = dt["AddressOfPersonal"].ToString();
                            Quant.Text = dt["Quant"].ToString();
                            Feetage.Text = dt["Feetage"].ToString();
                            UnitPrice.Text = dt["UnitPrice"].ToString();
                            UnityType.Text = dt["UnityType"].ToString();
                            TotalCost.Text = dt["TotalCost"].ToString();
                            ContractDate.Text = dt["ContractDate"].ToString();
                          


                        }

                    }

                    RemAmount.Text = BBAALL.GetTotalRemAmountOfWorkContract(ID).Rows[0][0].ToString();
                    PainAmount.Text = BBAALL.GetTotalPaidAmountOfWorkContract(ID).Rows[0][0].ToString();
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {
                    ID = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة قيد جديد";


                    DateTime dateTime = DateTime.UtcNow.Date;
                    ContractDate.Text = dateTime.ToString("dd/MM/yyyy");


                    ContractNumber.Text = "";
                    ContractType.Text = "";
                    NameOfPersonal.Text = "";
                    NumberOfPersonal.Text = "";
                    AddressOfPersonal.Text = "";
                    Quant.Text = "0";
                    Feetage.Text = "0";
                    UnitPrice.Text = "";
                    UnityType.Text = "";
                    TotalCost.Text = "";

                }

                CreateBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                //Button1.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");
                DelBtn.Visible = Session["Role"].Equals("تطوير") || Session["Role"].Equals("الحسابات");

            }

        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("WorkContracts.aspx");



        }

        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);




                BBAALL.InsertIntoWorkContracs(ContractNumber.Text, ContractType.Text, NameOfPersonal.Text,NumberOfPersonal.Text
                    , AddressOfPersonal.Text, Convert.ToInt32(Quant.Text),Convert.ToInt32(Feetage.Text),Convert.ToInt32(UnitPrice.Text)
                    ,UnityType.Text,0,ProjectID,ContractDate.Text
                    );
                ContractNumber.Text = "";
                ContractType.Text = "";
                NameOfPersonal.Text = "";
                NumberOfPersonal.Text = "";
                AddressOfPersonal.Text = "";
                Quant.Text = "";
                Feetage.Text = "";
                UnitPrice.Text = "";
                UnityType.Text = "";
                TotalCost.Text = "";
                Response.Redirect("WorkContracts.aspx");

            }
            else
            {


                BBAALL.UpdateIntoWorkContracs(ContractNumber.Text, ContractType.Text, NameOfPersonal.Text, NumberOfPersonal.Text
                   , AddressOfPersonal.Text, Convert.ToInt32(Quant.Text), Convert.ToInt32(Feetage.Text), Convert.ToInt32(UnitPrice.Text)
                   , UnityType.Text, Convert.ToInt32(TotalCost.Text), ID,ContractDate.Text
                   );

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";
                ContractNumber.Text = "";
                ContractType.Text = "";
                NameOfPersonal.Text = "";
                NumberOfPersonal.Text = "";
                AddressOfPersonal.Text = "";
                Quant.Text = "";
                Feetage.Text = "";
                UnitPrice.Text = "";
                UnityType.Text = "";
                TotalCost.Text = "";

                Response.Redirect("WorkContracts.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteWorkContract(ID);
            ID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد جديد";

            ContractNumber.Text = "";
            ContractType.Text = "";
            NameOfPersonal.Text = "";
            NumberOfPersonal.Text = "";
            AddressOfPersonal.Text = "";
            Quant.Text = "";
            Feetage.Text = "";
            UnitPrice.Text = "";
            UnityType.Text = "";
            TotalCost.Text = "";


            Response.Redirect("WorkContracts.aspx");



        }
    }
}