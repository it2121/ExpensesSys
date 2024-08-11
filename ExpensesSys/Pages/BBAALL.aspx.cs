using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class BBAALL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static DataTable LogIn(string Username, string Password)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "LogIn";
            cm.Parameters.AddWithValue("@Username", Username);
            cm.Parameters.AddWithValue("@Password", Password);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        public static DataTable getProjectNameByID(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getProjectNameByID";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        public static DataTable GetAllMaterialsOfProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllMaterialsOfProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } public static DataTable GetEmpOfProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetEmpOfProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
         
        public static DataTable getItemByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getItemByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        
        
        public static DataTable DeleteSalary(int SalaryIDRecord)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteSalary";
            cm.Parameters.AddWithValue("@SalaryIDRecord ", SalaryIDRecord);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        
           
        public static DataTable getSalaryRecBySalaryRecID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getSalaryRecBySalaryRecID";
            cm.Parameters.AddWithValue("@ID ", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        
        
        
        public static DataTable getSalaryByProjectID(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getSalaryByProjectID";
            cm.Parameters.AddWithValue("@ProjectID ", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  public static DataTable getEmpByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getEmpByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
         public static DataTable getProjctByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getProjctByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }


        public static DataTable GetAllEmp()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllEmp";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        
        public static DataTable GetAllMaterials()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllMaterials";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
           public static DataTable GetAllProjects()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllProjects";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }


        public static bool UpdateProject(string ProjectName,int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateProject";


            cm.Parameters.AddWithValue("@ProjectName", ProjectName);
            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
          public static bool UpdateItem(string ItemName,int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateItem";


            cm.Parameters.AddWithValue("@ItemName", ItemName);
            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
        
        
        public static bool InsertEmp(string EmpName, string EmpJob,int EmpSal, int ProjectID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertEmp";


            cm.Parameters.AddWithValue("@EmpName", EmpName);
            cm.Parameters.AddWithValue("@EmpJob", EmpJob);
            cm.Parameters.AddWithValue("@EmpSal", EmpSal);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        public static bool AutoInsertSalary(int EmpID, string RecDate, int ProjectID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "AutoInsertSalary";


            cm.Parameters.AddWithValue("@EmpID", EmpID);
            cm.Parameters.AddWithValue("@RecDate", RecDate);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }public static bool UpdateEmp(string EmpName, string EmpJob,int EmpSal,int ID,int ProjectID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateEmp";


            cm.Parameters.AddWithValue("@EmpName", EmpName);
            cm.Parameters.AddWithValue("@EmpJob", EmpJob);
            cm.Parameters.AddWithValue("@EmpSal", EmpSal);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
        
        
        public static bool InsertProject(string ProjectName)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertProject";


            cm.Parameters.AddWithValue("@ProjectName", ProjectName);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
        public static bool InsertItem(string ItemName,int ProjectID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertItem";


            cm.Parameters.AddWithValue("@ItemName", ItemName);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        public static bool InsertSalary(int ProjectID,int EmpID,string  RecDate, int Salary)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertSalary";


            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@EmpID", EmpID);
            cm.Parameters.AddWithValue("@RecDate", RecDate);
            cm.Parameters.AddWithValue("@Salary", Salary);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
         public static bool UpdateSalary(int ProjectID,int EmpID,string  RecDate, int Salary ,  int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateSalary";


            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@EmpID", EmpID);
            cm.Parameters.AddWithValue("@RecDate", RecDate);
            cm.Parameters.AddWithValue("@Salary", Salary);
            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
        
        
        public static bool DeleteProject(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteProject";


            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  public static bool DeleteItem(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteItem";


            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        public static bool DeleteEmp(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteEmp";


            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }



    }
}