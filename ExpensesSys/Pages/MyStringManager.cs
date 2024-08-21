using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Web;

namespace ExpensesSys.Pages
{
    public static class MyStringManager
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9'))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string GetNumberWithComas(string numberAsaString)
        {

            string st = MyStringManager.RemoveSpecialCharacters(numberAsaString);

            string returnString = $"{Convert.ToInt64(st):n0}";
            return returnString;

        }

        public static int GetIntFromNumberStringWithComas(string numWithComasAsString)
        {

            string st = MyStringManager.RemoveSpecialCharacters(numWithComasAsString);
            int RetuirnInt = Convert.ToInt32(st);
            return RetuirnInt;


        }
        public static  DataTable GetTableAfterDateCheck(DataTable InTbl ,string StartDate, string EndDate)
        {

            DataTable AfterDateDT = InTbl.Clone();
            DataTable retunrDT = AfterDateDT.Clone();
            retunrDT.Clone();
            if (StartDate.Length > 0 && EndDate.Length > 0)
            {
                AfterDateDT.Clear();

                foreach (DataRow dr in InTbl.Rows)
                {
                
                        DateTime Date = DateTime.ParseExact(dr["التاريخ"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        DateTime Startdate = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        DateTime Enddate = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                        int startResult = DateTime.Compare(Date, Startdate);
                        int endResult = DateTime.Compare(Enddate, Date);

                        if (startResult >= 0 && endResult >= 0)
                        {
                            AfterDateDT.ImportRow(dr);

                        }
                 

                }


                retunrDT = AfterDateDT;


            }
            else
            {
                retunrDT = InTbl;

            }

            return retunrDT;
        }


        public static DataTable ReturnTableWithCurrencyCommas (DataTable InTbl ,string FeildName)
        {
            DataTable NewTable = InTbl.Clone();

            NewTable.Clear();
            NewTable.Columns.Remove(FeildName);

            NewTable.Columns.Add(FeildName, typeof(String));

            foreach (DataRow dr in InTbl.Rows )


            {

                NewTable.ImportRow(dr);



            }
            int counter = 0;
            foreach (DataRow dr in InTbl.Rows )


            {

                NewTable.Rows[counter][FeildName] = GetNumberWithComas(dr[FeildName].ToString()+"");

                counter++;

            }



            return NewTable;

        } 


        public static int  ReturnSumOfDTFildInInt (DataTable InTbl ,string FildName)
        {
            int sum = 0;
            foreach (DataRow dr in InTbl.Rows)
            {

                sum += Convert.ToInt32(dr[FildName].ToString());


            }



            return sum;

        }

    }
}