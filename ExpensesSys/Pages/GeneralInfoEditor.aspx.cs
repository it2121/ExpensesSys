﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{

    public partial class GeneralInfoEditor : System.Web.UI.Page
    {

        public static string RecID = "";
        public static string RecdirectTo = "";
        public static int ProjectID = 0;
        public static string firstwarndate = "";
        public static string secondwarndate = "";  
        public static string firstwarnrecdate = "";
        public static string secondwarnrecdate = "";
   

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!RecID.Equals(""))
                {
                    DataTable OrEmpTbl = BBAALL.GetGeneralInfo(RecID);


                    foreach (DataRow dt in OrEmpTbl.Rows)
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


                        firstwarndate = dt["FirstWarnDate"].ToString();
                        secondwarndate = dt["SecondWarnDate"].ToString();
                        firstwarnrecdate = dt["FirstWarnRecDate"].ToString();
                        secondwarnrecdate = dt["SecondWarnRecDate"].ToString();


                        Loan.Checked = true;
                        Emp.Checked = true;
                        if (!dt["Emp"].ToString().Equals("1"))
                            Emp.Checked = false;

                        if (!dt["Loan"].ToString().Equals("1"))
                            Loan.Checked = false;


                        NonEmp.Checked = !Emp.Checked;
                        NonLoan.Checked = !Loan.Checked;
                    }



                }
                UpdateWarnPanels();


                if (Session["Role"].ToString().Equals("القانونية"))
                {
                    UniNumAndCat.ReadOnly = true;
                    ProNum.ReadOnly = true;
                    BuildArea.ReadOnly = true;
                    ProPrice.ReadOnly = true;

                    



                }else
                {
                    Warn.Enabled = false;
                }
            }
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

                Response.Redirect("PeojectUnit.aspx");

            }


        }


        protected void CreateItem(object sender, EventArgs e)
        {
            string EmpText = "0";
            
                string LoanText = "0";
              
                if (Loan.Checked)
                LoanText = "1";

            if (Emp.Checked)
              EmpText = "1";


            if (!RecID.Equals(""))
                {

                BBAALL.UpdateGeneralInfo(
           FullName.Text,
 PhoneNumber.Text,
 UniNumAndCat.Text,
 ProNum.Text,
Convert.ToInt32(BuildArea.Text),
Convert.ToInt32(ProPrice.Text),
 Address.Text,
 EmpText,
Convert.ToInt32(UniArea.Text),
 LoanText,
 RecID,
 GINote.Text, ProjectID, Warn.Text, FirstWarnDate.Text, SecondWarnDate.Text,FirstWarnRecDate.Text,SecondWarnRecDate.Text
 );



                if (RecdirectTo.Length != 0)
                {
                    UnitOverlook.RecID = RecID;
                    string temp = RecdirectTo;
                    RecdirectTo = "";
                    Response.Redirect(temp);

                }
                else
                {

                    Response.Redirect("PeojectUnit.aspx");

                }



                    // ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ORNumber.Text + Date.Text + Value.Text + checkedd + Note.Text + "');", true);


                    /*

                                    BBAALL.InsertIntoOrigenalEmp(EmpName.Text,
                                        EmpJob.Text, Depart.Text, Address.Text, Note.Text, InvolvmentType, ProjectID, HiringDate.Text, Termdate);

                                    Response.Redirect("OriginalEmp.aspx");*/

                
            }



        }

        public void UpdateWarnPanels()
        {

            if (Warn.Text.Equals("بلا انذار"))
            {
                FirstWarnPanel.Visible = false;
                SecondWarnPanel.Visible = false;
                FirstWarnDate.Text = "";
                FirstWarnRecDate.Text = "";
                SecondWarnDate.Text = "";
                SecondWarnRecDate.Text = "";


            }
            else if (Warn.Text.Equals("انذار اولي"))
            {

                FirstWarnPanel.Visible = true;
                SecondWarnPanel.Visible = false;
                FirstWarnDate.Text = firstwarndate;
                FirstWarnRecDate.Text = firstwarnrecdate;
                SecondWarnDate.Text = "";
                SecondWarnRecDate.Text = "";
            }
            else if (Warn.Text.Equals("انذار نهائي"))
            {
                FirstWarnPanel.Visible = true;
                SecondWarnPanel.Visible = true;
                FirstWarnDate.Text = firstwarndate;
                FirstWarnRecDate.Text = firstwarnrecdate;
                SecondWarnDate.Text = secondwarndate;
                SecondWarnRecDate.Text = secondwarnrecdate;
            }
            FirstWarnUpdatePanel.Update();
            SecondWanrUpdatePanel.Update();

            if (!Session["Role"].ToString().Equals("القانونية"))
            {

                FirstWarnDate.ReadOnly = true;
                FirstWarnRecDate.ReadOnly = true;
                SecondWarnDate.ReadOnly = true;
                SecondWarnRecDate.ReadOnly = true;

            }else
            {

                FirstWarnDate.ReadOnly = false;
                FirstWarnRecDate.ReadOnly = false;
                SecondWarnDate.ReadOnly = false;
                SecondWarnRecDate.ReadOnly =false;
            }

        }
        protected void myListDropDown_Change(object sender, EventArgs e)
        {

            UpdateWarnPanels();

        }
    }
}