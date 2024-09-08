using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpensesSys.Pages
{
    public class Global
    {
        public static int ProjecID = 0;

        public static void setProjectID (int projectID)
        {
            ProjecID = projectID;
        }
        public static int getProjectID() {
            return ProjecID;
        }
    }
}