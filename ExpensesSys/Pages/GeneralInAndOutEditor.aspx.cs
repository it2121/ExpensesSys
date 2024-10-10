using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class GeneralInAndOutEditor : System.Web.UI.Page
    {
        public static int ID = 0;
        public static string  RecType = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
                if (ID != 0)
                {


                    DataTable CompTbl = BBAALL.GetGeneralInAndOutByID(ID);

                    DelBtn.Visible = true;
                    foreach (DataRow dt in CompTbl.Rows)
                    {
                        if (ID.Equals(dt[0]))
                        {



                            Date.Text = dt["Date"].ToString();
                            Amount.Text = dt["Amount"].ToString();
                            Note.Text = dt["Note"].ToString();


                        }

                    }

                    DelBtn.Visible = true;
                    CreateBtn.Text = "حفظ التعديلات";


                }
                else
                {



                    ID = 0;
                    DelBtn.Visible = false;


                    if (RecType.Equals("In"))
                      CreateBtn.Text = "اضافة تقرير وارد  جديد";

                    if(RecType.Equals("Out"))
                    CreateBtn.Text = "اضافة تقرير صرف  جديد";

                    DateTime dateTime = DateTime.UtcNow.Date;
                    Date.Text = dateTime.ToString("dd/MM/yyyy");

                    Amount.Text = "";
                    Note.Text = "";
             

                }
            }
        }
        protected void Return(object sender, EventArgs e)
        {


            Response.Redirect("GeneralInAndOut.aspx");



        }
        protected void CreateItem(object sender, EventArgs e)
        {
            if (ID == 0)
            {


                // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);



                BBAALL.InsertIntoGeneralInAndOut(
                    MyStringManager.GetDateAfterCheckingFormating(Date.Text),
                    Convert.ToInt32(Amount.Text),RecType,Note.Text
                    );

                Response.Redirect("GeneralInAndOut.aspx");

            }
            else
            {


                BBAALL.UpdateIntoGeneralInAndOut(
                   MyStringManager.GetDateAfterCheckingFormating(Date.Text),
                   Convert.ToInt32(Amount.Text), Note.Text,ID
                   );


             

                ID = 0;
                DelBtn.Visible = false;

                CreateBtn.Text = "اضافة قيد جديد";


                Response.Redirect("GeneralInAndOut.aspx");
            }


        }
        protected void DelProv(object sender, EventArgs e)
        {

            BBAALL.DeleteGeneralInAndOutByID(ID);
            ID = 0;
            DelBtn.Visible = false;







            Response.Redirect("GeneralInAndOut.aspx");



        }

    }
}