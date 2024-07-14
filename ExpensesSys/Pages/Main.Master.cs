using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{

    public partial class Main : System.Web.UI.MasterPage
    {
        public static string openPage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["redirected"] = "0";
            if (Session["Name"] == null && Session["redirected"].ToString().Equals("0"))
            {
                Session["redirected"] = "1";
                // redirected=true;
                Response.Redirect("LogInSeprate.aspx");

            }
            else if (Session["Name"] != null)
            {

                /*  Users user = (Users)Session["User"];
                  NavBar.Visible = true;


                  UserFullNameLbl.Text = user.Fullname;

  */


            }
            TLbl.Text= Session["Name"].ToString();
            NameL.Text = Session["Role"].ToString();

            setSelectedPageBGColor(openPage);


        }
        public void setSelectedPageBGColor(string pageName) {

            if (pageName.Equals("Home"))
            {
                Home.BackColor = ColorTranslator.FromHtml("#3399ff");


            }
        
        }
    }
}