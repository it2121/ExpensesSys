using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class MatBuyEditor : System.Web.UI.Page
    {
        public static int MatBuyRecId = 0;
        public static int ProjectID = 0;
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


                            RemAmount.Text = Convert.ToInt32(TotalCost.Text) - Convert.ToInt32(RecAmount.Text)+"";

                        }

                    }
                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";
                    if (ProvidedQuant.Text.Length > 0) { 
                   ProvidedQuantPrice.Text =  (Convert.ToInt32(TotalCost.Text) / Convert.ToInt32(Quant.Text)) * Convert.ToInt32(ProvidedQuant.Text) +"" ;
                    }
                    else
                    {
                        ProvidedQuantPrice.Text = "0";
                        ProvidedQuant.Text = "0";



                    }


                }
                else
                {
                    MatBuyRecId = 0;
                    DelBtn.Visible = false;

                    CreateBtn.Text = "اضافة قيد شراء جديد";
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
            }

        }

        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("MatBuy.aspx");



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

                CreateBtn.Text = "اضافة موظف جديد";


                Response.Redirect("MatBuy.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteMatBuy(MatBuyRecId);
            MatBuyRecId = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة قيد شراء جديد";


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