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
    }
}