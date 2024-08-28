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

   public static DataTable getAllWarehouse()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllWarehouse";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }        public static DataTable REP_GetAllNthRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllNthRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   
        public static DataTable REP_GetAllCompRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllCompRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable REP_GetAllSalaryRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllSalaryRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        public static DataTable REP_GetAllMatBuyRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllMatBuyRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        public static DataTable REP_GetAllIncomeRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllIncomeRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
            public static DataTable GetAllIncomeSum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllIncomeSum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        
        public static DataTable getAllProjectCount()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllProjectCount";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }       public static DataTable getAllEmpCount()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllEmpCount";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
             public static DataTable GetAllOutcomeSum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllOutcomeSum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  



           public static DataTable getAllOrigenalEmp(int ProjectID,string InvolvmentType)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllOrigenalEmp";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@InvolvmentType", InvolvmentType);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable getOrigenalEmpByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getOrigenalEmpByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable getWarehouseByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getWarehouseByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
           public static DataTable DeleteOriginalEmp(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteOriginalEmp";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable DeletePay(int ID , int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeletePay";
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
        
        
        public static DataTable getCompByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getCompByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        
        
        public static DataTable getPayByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getPayByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  


        
        
        public static DataTable GetAllNthSum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();


            cm.CommandText = "GetAllNthSum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        public static DataTable GetAllCompSum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();


            cm.CommandText = "GetAllCompSum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable GetAllSalarySum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();


            cm.CommandText = "GetAllSalarySum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    public static DataTable GetAllMatBuySum()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();


            cm.CommandText = "GetAllMatBuySum";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    public static DataTable GetAllIncomeSumLast30()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            DateTime dateTime = DateTime.Now.AddDays(-30);

            string Date =  dateTime.ToString("dd/MM/yyyy");

            cm.CommandText = "GetAllIncomeSumLast30";
            cm.Parameters.AddWithValue("@Date", Date);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
              public static DataTable GetAllOutcomeSumLast30()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            DateTime dateTime = DateTime.Now.AddDays(-30);

            string Date =  dateTime.ToString("dd/MM/yyyy");

            cm.CommandText = "GetAllOutcomeSumLast30";
            cm.Parameters.AddWithValue("@Date", Date);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        
        
        
        public static DataTable getIncomeByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getIncomeByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
            public static DataTable getAllIncomeOfProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllIncomeOfProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        
        
        public static DataTable getAllCompOfProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllCompOfProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable getPayCountByRecID(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getPayCountByRecID";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
        
        
        
        public static DataTable getMatBuyRecByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getMatBuyRecByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
        public static DataTable GetMatBuyOfAProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetMatBuyOfAProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
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
        
        
        public static DataTable DeleteIncome(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteIncome";
            cm.Parameters.AddWithValue("@ID ", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   
        
        public static DataTable DeleteMatBuy(int MatBuyRecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteMatBuy";
            cm.Parameters.AddWithValue("@MatBuyRecID ", MatBuyRecID);
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
        
           
        public static DataTable getAllNth()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllNth";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }       
        public static DataTable getNthByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getNthByID";
            cm.Parameters.AddWithValue("@ID ", ID);
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
        
        
        
        public static DataTable getAllPayByRecID(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllPayByRecID";
            cm.Parameters.AddWithValue("@RecID ", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    
        public static DataTable getMatNameByMatBuyID(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getMatNameByMatBuyID";
            cm.Parameters.AddWithValue("@RecID ", RecID);
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
        }  
        
        
        public static DataTable getEmpByID(int ID)
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



        }  public static bool UpdateComp(int ID, string NameOrReason, int Cost , string PayDate,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateComp";


            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@NameOrReason", NameOrReason);
            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@PayDate", PayDate);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
        public static bool InsertComp( string NameOrReason, int Cost , string PayDate ,int ProjectID ,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertComp";


            cm.Parameters.AddWithValue("@NameOrReason", NameOrReason);
            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@PayDate", PayDate);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  
        
        public static bool UpdateOrigenalEmp( string EmpName, string EmpJob, string Depart, string Address, 
            string Note,string InvolvmentType, int ProjectID,int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateOrigenalEmp";


            cm.Parameters.AddWithValue("@EmpName", EmpName);
            cm.Parameters.AddWithValue("@EmpJob", EmpJob);
            cm.Parameters.AddWithValue("@Depart", Depart);
            cm.Parameters.AddWithValue("@Address", Address);
            cm.Parameters.AddWithValue("@Note", Note);
            cm.Parameters.AddWithValue("@InvolvmentType", InvolvmentType);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@ID", ID);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);


        }    public static bool InsertIntoOrigenalEmp( string EmpName, string EmpJob, string Depart, string Address, 
            string Note,string InvolvmentType, int ProjectID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoOrigenalEmp";


            cm.Parameters.AddWithValue("@EmpName", EmpName);
            cm.Parameters.AddWithValue("@EmpJob", EmpJob);
            cm.Parameters.AddWithValue("@Depart", Depart);
            cm.Parameters.AddWithValue("@Address", Address);
            cm.Parameters.AddWithValue("@Note", Note);
            cm.Parameters.AddWithValue("@InvolvmentType", InvolvmentType);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);


        } 
        
        public static bool UpdateWarehouse( int MatBuyID, string ActionType, int Quant,int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateWarehouse";


            cm.Parameters.AddWithValue("@MatBuyID", MatBuyID);
            cm.Parameters.AddWithValue("@ActionType", ActionType);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@ID", ID);

      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
        
        
        public static bool InsertIntoWarehouse( int MatBuyID, string ActionType, int Quant)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoWarehouse";


            cm.Parameters.AddWithValue("@MatBuyID", MatBuyID);
            cm.Parameters.AddWithValue("@ActionType", ActionType);
            cm.Parameters.AddWithValue("@Quant", Quant);

      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } public static bool InserIncome( string TypeOfIncome, int Amount ,int ProjectID, string IncomeDate, string Note)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InserIncome";


            cm.Parameters.AddWithValue("@TypeOfIncome", TypeOfIncome);
            cm.Parameters.AddWithValue("@Amount", Amount);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@IncomeDate", IncomeDate);
            cm.Parameters.AddWithValue("@Note", Note);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } public static bool UpdateIncome( string TypeOfIncome, int Amount ,int ProjectID, string IncomeDate, string Note,int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateIncome";


            cm.Parameters.AddWithValue("@TypeOfIncome", TypeOfIncome);
            cm.Parameters.AddWithValue("@Amount", Amount);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@IncomeDate", IncomeDate);
            cm.Parameters.AddWithValue("@Note", Note);
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
        
        
        public static bool UpdaeMatBuy(string MatName, int Quant, int Count , string MatType, int TotalCost,
           
            int ProjectID,
            string BuyingParty,
            string Buyer,
            int MatBuyRecID,
            string WereHouseState
            )



        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdaeMatBuy";


            cm.Parameters.AddWithValue("@MatName", MatName);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@MatType", MatType);
            cm.Parameters.AddWithValue("@TotalCost", TotalCost);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@BuyingParty", BuyingParty);
            cm.Parameters.AddWithValue("@Buyer", Buyer);
            cm.Parameters.AddWithValue("@Count", Count);
            cm.Parameters.AddWithValue("@MatBuyRecID", MatBuyRecID);
            cm.Parameters.AddWithValue("@WereHouseState", WereHouseState);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
            public static bool InsertMatBuy(string MatName, int Quant, int Count , string MatType, int TotalCost,
           
            int ProjectID,
            string BuyingParty,
            string Buyer,
                        string WereHouseState

            )



        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertMatBuy";


            cm.Parameters.AddWithValue("@MatName", MatName);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@MatType", MatType);
            cm.Parameters.AddWithValue("@TotalCost", TotalCost);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@BuyingParty", BuyingParty);
            cm.Parameters.AddWithValue("@Buyer", Buyer);
            cm.Parameters.AddWithValue("@Count", Count);
            cm.Parameters.AddWithValue("@WereHouseState", WereHouseState);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
        
        
        public static bool updatePay(int PaidAmount, string Date, int RecID, int ID,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "updatePay";


            cm.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cm.Parameters.AddWithValue("@Date", Date);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }    
        public static bool UpdateNth(string Name, int Quant, string BuyDate,int Cost ,int ID, string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateNth";


            cm.Parameters.AddWithValue("@Name", Name);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@BuyDate", BuyDate);
            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  
          public static bool InsertNth(string Name, int Quant, string BuyDate,int Cost , string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertNth";


            cm.Parameters.AddWithValue("@Name", Name);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@BuyDate", BuyDate);
            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  
        
        
        public static bool InsertPay(int PaidAmount, string Date, int RecID,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertPay";


            cm.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cm.Parameters.AddWithValue("@Date", Date);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


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
        public static bool AutoInsertSalary(int EmpID, string RecDate, int ProjectID,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "AutoInsertSalary";


            cm.Parameters.AddWithValue("@EmpID", EmpID);
            cm.Parameters.AddWithValue("@RecDate", RecDate);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


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
        public static bool InsertSalary(int ProjectID,int EmpID,string  RecDate, int Salary ,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertSalary";


            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@EmpID", EmpID);
            cm.Parameters.AddWithValue("@RecDate", RecDate);
            cm.Parameters.AddWithValue("@Salary", Salary);
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
         public static bool UpdateSalary(int ProjectID,int EmpID,string  RecDate, int Salary ,  int ID,string WithdrowParty)

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
            cm.Parameters.AddWithValue("@WithdrowParty", WithdrowParty);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }
        
        
        
        public static bool DeleteNth(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteNth";


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



        }  
        
        
        
        public static bool deleteWarehouse(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "deleteWarehouse";


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