using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpensesSys.Pages
{
    public class Global
    {
        public static int ProjecID = 0;
        public static string Role = "";

        public static void setRole(string role)
        {
            Role = role;
        }
        public static string GetRole() {
            return Role;
        } public static void setProjectID (int projectID)
        {
            ProjecID = projectID;
        }
        public static int getProjectID() {
            return ProjecID;
        }
    }
}