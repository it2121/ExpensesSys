using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class ContractsEditor : System.Web.UI.Page
    {
        public static int ContractID = 0;
        public static int ProjectID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ProjectID = Convert.ToInt32(Session["ProjectID"].ToString());
                if (ContractID != 0)
                {
                    DataTable ProjectDT = BBAALL.GetContractByIDLAW(ContractID);

                    foreach (DataRow dt in ProjectDT.Rows)
                    {
                        



                            ContractDate.Text = dt["ContractDate"].ToString();
                            ContractType.Text = dt["ContractType"].ToString();
                            ContractingWithParty.Text = dt["ContractingWithParty"].ToString();
                            Notes.Text = dt["Notes"].ToString();
                            ContractNumber.Text = dt["ContractNumber"].ToString();
                        ContractSub.Text = dt["ContractSub"].ToString();


                        

                    }
                    CreateBtn.Text = "حفظ التعديلات";
                    DelBtn.Visible = true;

                }
                else
                {
                    ContractID = 0;


                    CreateBtn.Text = "اضافة عقد جديد";
                    DelBtn.Visible = false;
                    ContractDate.Text = "";
                    ContractType.Text = "";
                    ContractingWithParty.Text = "";
                    Notes.Text = "";
                    ContractNumber.Text = "";
                    ContractSub.Text = "";


                    DateTime dateTime = DateTime.UtcNow.Date;
                    ContractDate.Text = dateTime.ToString("dd/MM/yyyy");

                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("LAWContracts.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ContractID == 0)
            {



                BBAALL.InsertIntoContactsLAW(
                    ContractDate.Text,
                    ContractType.Text,
                    ContractingWithParty.Text,
                    Notes.Text,
                    ContractNumber.Text, ProjectID, ContractSub.Text
                    );

                Response.Redirect("LAWContracts.aspx");

            }
            else
            {

                BBAALL.UpdateContactsLAW(
                                   ContractDate.Text,
                                   ContractType.Text,
                                   ContractingWithParty.Text,
                                   Notes.Text,
                                   ContractNumber.Text, 
                                   ProjectID,
                                   ContractID, ContractSub.Text
                                   );
                ContractID = 0;

                CreateBtn.Text = "اضافة عقد جديد";


                ContractDate.Text = "";
                ContractType.Text = "";
                ContractingWithParty.Text = "";
                Notes.Text = "";
                ContractNumber.Text = "";
                ContractSub.Text = "";
                Response.Redirect("LAWContracts.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteContractLAW(ContractID);
            ProjectID = 0;
            DelBtn.Visible = false;

            CreateBtn.Text = "اضافة عقد جديد";



            ContractDate.Text = "";
            ContractType.Text = "";
            ContractingWithParty.Text = "";
            Notes.Text = "";
            ContractNumber.Text = "";
            ContractSub.Text = "";

            Response.Redirect("LAWContracts.aspx");



        }
    }
}