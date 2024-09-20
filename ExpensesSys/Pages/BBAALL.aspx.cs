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



        public static DataTable DeleteFile(int  ID)
        {


            SqlCommand cm;
            cm = DDAALL.CreateCommandLAW();
            cm.CommandText = "DeleteFile";

            cm.Parameters.AddWithValue("@ID", ID);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  public static DataTable GetFileByDockID(int  ID)
        {


            SqlCommand cm;
            cm = DDAALL.CreateCommandLAW();
            cm.CommandText = "GetFileByDockID";

            cm.Parameters.AddWithValue("@ID", ID);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        public static DataTable GetAllDocksOrARecID(string  RecID)
        {


            SqlCommand cm;
            cm = DDAALL.CreateCommandLAW();
            cm.CommandText = "GetAllDocksOrARecID";

            cm.Parameters.AddWithValue("@RecID", RecID);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
        public static DataTable Upload(byte[] Doc ,string  RecID, string DocName, string DocType)
        {


            SqlCommand cm;
            cm = DDAALL.CreateCommandLAW();
            cm.CommandText = "Upload";

            cm.Parameters.AddWithValue("@Doc", Doc);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@DocName", DocName);
            cm.Parameters.AddWithValue("@DocType", DocType);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }



        public static DataTable getAllWarehouse()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllWarehouse";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    
        public static DataTable REP_GetAllWorkContractsPaymentRecords()
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "REP_GetAllWorkContractsPaymentRecords";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable REP_GetAllNthRecords()
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



           public static DataTable GetAllWeightsForProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllWeightsForProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 


           public static DataTable GetAllUnitsOfAPorjectAndAType(int ProjectID , string UnitType)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllUnitsOfAPorjectAndAType";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable GetWeightsForUnit(int ProjectID , string UnitType )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWeightsForUnit";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }       public static DataTable GetSearchListByWord(int ProjectID,string SearchText)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetSearchListByWord";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@SearchText", SearchText);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable GetSearchList(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetSearchList";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 


           public static DataTable GetWeightSectionsByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWeightSectionsByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }       public static DataTable GetAllUnitTypesOfProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllUnitTypesOfProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
          public static DataTable GetWeightsByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWeightsByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        

           public static DataTable GetAllWeightSections(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllWeightSections";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        
        public static DataTable getCoutOfUnitsForWorkContracts(int WorkContractID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getCoutOfUnitsForWorkContracts";
            cm.Parameters.AddWithValue("@WorkContractID", WorkContractID);
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
        } 
              public static DataTable GetAllWarehouseRecordsOfMatBuy(int MatBuyID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllWarehouseRecordsOfMatBuy";
            cm.Parameters.AddWithValue("@MatBuyID", MatBuyID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
              public static DataTable GetWarehouseRecordForAMatyBuy(int MatBuyID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWarehouseRecordForAMatyBuy";
            cm.Parameters.AddWithValue("@MatBuyID", MatBuyID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
        
        
        
        public static DataTable GetFinanceByRecID(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetFinanceByRecID";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        public static DataTable GetWhatShouldBePaidForRecID(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWhatShouldBePaidForRecID";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }      public static DataTable getComPre(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getComPre";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   
        
        
        public static DataTable GetPaidAmount(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetPaidAmount";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    
        public static DataTable GetAllWorkContractsOFAProject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllWorkContractsOFAProject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
           
        
        public static DataTable CheckIfUnitExistInWorkContract(int WorkContractID,string UnitRecID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "CheckIfUnitExistInWorkContract";
            cm.Parameters.AddWithValue("@WorkContractID", WorkContractID);
            cm.Parameters.AddWithValue("@UnitRecID", UnitRecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable GetUnitsPerContractOfAContract(int WorkContractID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetUnitsPerContractOfAContract";
            cm.Parameters.AddWithValue("@WorkContractID", WorkContractID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }      
           public static DataTable GetAllUnitsOfAPorject(int ProjectID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllUnitsOfAPorject";
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }      
        
        
        public static DataTable GetTotalRemAmountOfWorkContract(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetTotalRemAmountOfWorkContract";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }      public static DataTable GetAllUnitPaymentsOfRecID(string RecID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetAllUnitPaymentsOfRecID";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable GetTotalPaidAmountOfWorkContract(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetTotalPaidAmountOfWorkContract";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable GetUnitPaymentByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetUnitPaymentByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  public static DataTable getUnitByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getUnitByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  public static DataTable GetWorkContractByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetWorkContractByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
            public static DataTable getOrigenalEmpByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getOrigenalEmpByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }  
        
        
        
        
        public static DataTable getWarehouseByID(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getWarehouseByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
           public static DataTable DeleteUnitPayments(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteUnitPayments";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
           public static DataTable DeleteWeights(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteWeights";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable DeleteOriginalEmp(int ID )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteOriginalEmp";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }   public static DataTable DeleteWorkContractPay(int ID , int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteWorkContractPay";
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        } 
           public static DataTable DeletePay(int ID , int RecID)
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
        
        
        
        public static DataTable getWorkContractPayByID(int ID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getWorkContractPayByID";
            cm.Parameters.AddWithValue("@ID", ID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }      public static DataTable getPayByID(int ID)
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
        
        
        public static DataTable GetTechInfo(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetTechInfo";
            cm.Parameters.AddWithValue("@RecID", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }     public static DataTable GetGeneralInfo(string RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "GetGeneralInfo";
            cm.Parameters.AddWithValue("@RecID", RecID);
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
        
        public static DataTable DeleteMatBuy(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "DeleteMatBuy";
            cm.Parameters.AddWithValue("@RecID ", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }
           public static DataTable getProvidedQuantByMatBuyID(int MatBuyID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getProvidedQuantByMatBuyID";
            cm.Parameters.AddWithValue("@MatBuyID ", MatBuyID);
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
           
        public static DataTable getWorkContractHeaderInfoBuyID(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getWorkContractHeaderInfoBuyID";
            cm.Parameters.AddWithValue("@RecID ", RecID);
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteSelectCommand(cm);
        }    public static DataTable getAllWorkContractsPayByRecID(int RecID)
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();

            cm.CommandText = "getAllWorkContractsPayByRecID";
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
        public static bool InsertIntoWorkContracs(


             string ContractNumber ,
string ContractType ,
string NameOfPersonal ,
string NumberOfPersonal ,
string AddressOfPersonal ,
int Quant ,
int Feetage ,
int UnitPrice ,
string UnityType ,
int TotalCost ,
int ProjectID ,
string ContractDate

            )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoWorkContracs";
            cm.Parameters.AddWithValue("@ContractNumber", ContractNumber);
            cm.Parameters.AddWithValue("@ContractType", ContractType);
            cm.Parameters.AddWithValue("@NameOfPersonal", NameOfPersonal);
            cm.Parameters.AddWithValue("@NumberOfPersonal", NumberOfPersonal);
            cm.Parameters.AddWithValue("@AddressOfPersonal", AddressOfPersonal);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@Feetage", Feetage);
            cm.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            cm.Parameters.AddWithValue("@UnityType", UnityType);
            cm.Parameters.AddWithValue("@TotalCost", TotalCost);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@ContractDate", ContractDate);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }     public static bool UpdateIntoWorkContracs(


             string ContractNumber ,
string ContractType ,
string NameOfPersonal ,
string NumberOfPersonal ,
string AddressOfPersonal ,
int Quant ,
int Feetage ,
int UnitPrice ,
string UnityType ,
int TotalCost ,
int ID ,
string ContractDate 

            )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateIntoWorkContracs";
            cm.Parameters.AddWithValue("@ContractNumber", ContractNumber);
            cm.Parameters.AddWithValue("@ContractType", ContractType);
            cm.Parameters.AddWithValue("@NameOfPersonal", NameOfPersonal);
            cm.Parameters.AddWithValue("@NumberOfPersonal", NumberOfPersonal);
            cm.Parameters.AddWithValue("@AddressOfPersonal", AddressOfPersonal);
            cm.Parameters.AddWithValue("@Quant", Quant);
            cm.Parameters.AddWithValue("@Feetage", Feetage);
            cm.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            cm.Parameters.AddWithValue("@UnityType", UnityType);
            cm.Parameters.AddWithValue("@TotalCost", TotalCost);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@ContractDate", ContractDate);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }    
        
        public static bool DeleteUnitToWorkContract( int WorkContractID, string UnitRecID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteUnitToWorkContract";


            cm.Parameters.AddWithValue("@WorkContractID", WorkContractID);
            cm.Parameters.AddWithValue("@UnitRecID", UnitRecID);

      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }     public static bool InsertIntoUnitToWorkContract( int WorkContractID, string UnitRecID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoUnitToWorkContract";


            cm.Parameters.AddWithValue("@WorkContractID", WorkContractID);
            cm.Parameters.AddWithValue("@UnitRecID", UnitRecID);

      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }     public static bool InsertUnit( string NameOfUnit, string IDOFUnitIfExist , int ProjectID,string UnitType )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertUnit";


            cm.Parameters.AddWithValue("@NameOfUnit", NameOfUnit);
            cm.Parameters.AddWithValue("@IDOFUnitIfExist", IDOFUnitIfExist);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);

      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  public static bool UpdateUnit( string NameOfUnit, string IDOFUnitIfExist , int ProjectID ,int ID,string UnitType)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateUnit";


            cm.Parameters.AddWithValue("@NameOfUnit", NameOfUnit);
            cm.Parameters.AddWithValue("@IDOFUnitIfExist", IDOFUnitIfExist);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);

      


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
        
        
        public static bool InsertIntoWeights(
            int Cost, string WeightText, int ProjectID, string UnitType , int  Precentage)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoWeights";


            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@WeightText", WeightText);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);
            cm.Parameters.AddWithValue("@Precentage", Precentage);
      
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);

        }  
        
        public static bool UpdateWeights(
            int Cost, string WeightText, int ProjectID, string UnitType,int ID , int Precentage)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateWeights";


            cm.Parameters.AddWithValue("@Cost", Cost);
            cm.Parameters.AddWithValue("@WeightText", WeightText);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@UnitType", UnitType);
            cm.Parameters.AddWithValue("@ID", ID);
            cm.Parameters.AddWithValue("@Precentage", Precentage);
      
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);

        }  
         public static bool InsertWarehouse( int MatBuyID, string ActionType, int Quant)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertWarehouse";


            cm.Parameters.AddWithValue("@MatBuyID", MatBuyID);
            cm.Parameters.AddWithValue("@ActionType", ActionType);
            cm.Parameters.AddWithValue("@Quant", Quant);


    
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }  
        
        public static bool UpdateOrigenalEmp( string EmpName, string EmpJob, string Depart, string Address, 
            string Note,string InvolvmentType, int ProjectID,int ID, string HiringDate, string TreminationDate)

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
            cm.Parameters.AddWithValue("@HiringDate", HiringDate);
            cm.Parameters.AddWithValue("@TreminationDate", TreminationDate);

            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);


        } 
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public static bool InsertIntoOrigenalEmp( string EmpName, string EmpJob, string Depart, string Address, 
            string Note,string InvolvmentType, int ProjectID ,string HiringDate , string TreminationDate )

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
            cm.Parameters.AddWithValue("@HiringDate", HiringDate);
            cm.Parameters.AddWithValue("@TreminationDate", TreminationDate);


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);


        } 
        
        public static bool GetAllLawUnitInfo( )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "GetAllLawUnitInfo";
            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);
        }  public static bool KillDataBase( )
        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "KillDataBase";
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



        }
        
        
        public static bool UpdateGeneralInfo(
          string FullName,
string PhoneNumber ,
string UniNumAndCat ,
string ProNum ,
int  BuildArea ,
int ProPrice ,
string Address ,
string Emp ,
int UniArea ,
string Loan ,
string RecID ,
string GINote ,
int ProjectID,
string Warn
 )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateGeneralInfo";


            cm.Parameters.AddWithValue("@FullName", FullName);
            cm.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            cm.Parameters.AddWithValue("@UniNumAndCat", UniNumAndCat);
            cm.Parameters.AddWithValue("@ProNum", ProNum);
            cm.Parameters.AddWithValue("@BuildArea", BuildArea);
            cm.Parameters.AddWithValue("@ProPrice", ProPrice);
            cm.Parameters.AddWithValue("@Address", Address);
            cm.Parameters.AddWithValue("@Emp", Emp);
            cm.Parameters.AddWithValue("@UniArea", UniArea);
            cm.Parameters.AddWithValue("@Loan", Loan);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@GINote", GINote);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@Warn", Warn);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }        
        
        public static bool UpdateIncome( string TypeOfIncome, int Amount ,int ProjectID, string IncomeDate, string Note,int ID)

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



        }   public static bool UpdateTechInfo( string BuiType, int ComPre, string ComStage, string RecID,int ProjectID,int WeightReachedRecordID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateTechInfo";


            cm.Parameters.AddWithValue("@BuiType", BuiType);
            cm.Parameters.AddWithValue("@ComPre", ComPre);
            cm.Parameters.AddWithValue("@ComStage", ComStage);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@ProjectID", ProjectID);
            cm.Parameters.AddWithValue("@WeightReachedRecordID", WeightReachedRecordID);
     
      


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



        }   public static bool UpdateTotalPrice(string RecID, int Total)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateTotalPrice";


            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@Total", Total);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
        
        
        public static bool UpdaeMatBuy(string MatName, int Quant, int Count , string MatType, int TotalCost,
           
            int ProjectID,
            string BuyingParty,
            string Buyer,
            int MatBuyRecID,
            string ContractNumber,
            string ContractDate,
            string MatUnit,
            string NameOfSupplyer,
            string NumberOfSupplyer,
                        string AddressOfSupplyer




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
            cm.Parameters.AddWithValue("@NumberOfSupplyer", NumberOfSupplyer);
            cm.Parameters.AddWithValue("@NameOfSupplyer", NameOfSupplyer);
            cm.Parameters.AddWithValue("@MatUnit", MatUnit);
            cm.Parameters.AddWithValue("@ContractDate", ContractDate);
            cm.Parameters.AddWithValue("@ContractNumber", ContractNumber);
            cm.Parameters.AddWithValue("@AddressOfSupplyer", AddressOfSupplyer);



            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        } 
            public static bool InsertMatBuy(string MatName, int Quant, int Count , string MatType, int TotalCost,
           
            int ProjectID,
            string BuyingParty,
            string Buyer,
   string ContractNumber,
            string ContractDate,
            string MatUnit,
            string NameOfSupplyer,
            string NumberOfSupplyer,
            string AddressOfSupplyer
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
            cm.Parameters.AddWithValue("@NumberOfSupplyer", NumberOfSupplyer);
            cm.Parameters.AddWithValue("@NameOfSupplyer", NameOfSupplyer);
            cm.Parameters.AddWithValue("@MatUnit", MatUnit);
            cm.Parameters.AddWithValue("@ContractDate", ContractDate);
            cm.Parameters.AddWithValue("@ContractNumber", ContractNumber);
            cm.Parameters.AddWithValue("@AddressOfSupplyer", AddressOfSupplyer);


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



        }       public static bool updateWorkContractPay(int PaidAmount, string Date, int RecID, int ID,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "updateWorkContractPay";


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
          public static bool InsertIntoUnitPayments(int PayNo, int Amount, string DateOfPay, int PaidAmount
              , string RecID , string Paid )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertIntoUnitPayments";


            cm.Parameters.AddWithValue("@PayNo", PayNo);
            cm.Parameters.AddWithValue("@Amount", Amount);
            cm.Parameters.AddWithValue("@DateOfPay", DateOfPay);
            cm.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@Paid", Paid);

            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);

        }      public static bool UpdateUnitPayments(int PayNo, int Amount, string DateOfPay, int PaidAmount
              , string RecID , string Paid ,int ID )

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "UpdateUnitPayments";


            cm.Parameters.AddWithValue("@PayNo", PayNo);
            cm.Parameters.AddWithValue("@Amount", Amount);
            cm.Parameters.AddWithValue("@DateOfPay", DateOfPay);
            cm.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            cm.Parameters.AddWithValue("@RecID", RecID);
            cm.Parameters.AddWithValue("@Paid", Paid);
            cm.Parameters.AddWithValue("@ID", ID);

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



        }     public static bool InsertWorkContractPay(int PaidAmount, string Date, int RecID,string WithdrowParty)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "InsertWorkContractPay";


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



        }    public static bool DeleteUnit(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteUnit";


            cm.Parameters.AddWithValue("@ID", ID);
      


            SqlConnection.ClearAllPools();
            return DDAALL.ExecuteCommand(cm);



        }      public static bool DeleteWorkContract(int ID)

        {
            SqlCommand cm;
            cm = DDAALL.CreateCommand();
            if (cm == null) { return false; }
            cm.CommandText = "DeleteWorkContract";


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