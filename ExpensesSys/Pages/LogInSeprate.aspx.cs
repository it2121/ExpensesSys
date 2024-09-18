﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class LogInSeprate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["redirected"] = "1";


            }

        }
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {

            DataTable login = BBAALL.LogIn(UsernameTB.Text, PassTB.Text);

            if (login.Rows.Count > 0)
            {
                string temp = "";
                if (Convert.ToInt32(DateTime.Now.Month.ToString()) < 10)
                {
                    temp = "0" + DateTime.Now.Month + "/" + DateTime.Now.Year;

                }
                else
                {
                    temp = DateTime.Now.Month + "/" + DateTime.Now.Year;


                }
                Session["Month"] = temp;

                Session["Name"] = login.Rows[0]["Name"];

                Session["Role"] = login.Rows[0]["Role"];

                Session["redirected"] = "1";
                PeojectSeector.GoToPage = "Home";
                WorngLbl.Visible = false;

                Response.Redirect("SeperateProjectSelector.aspx");

            }
            else
            {
                WorngLbl.Visible = true;

            }

        }
    }
    }