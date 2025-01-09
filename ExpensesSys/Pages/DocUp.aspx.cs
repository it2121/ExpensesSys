using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExpensesSys.Pages
{
    public partial class DocUp : System.Web.UI.Page
    {
        public static int RecordID = 0;
        public static string ReturnToPage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                UpLbl.Text = " رفع المستندات " ;

             


            }
        }
        public static byte[] Data = null;
        public bool FileSelected = false;
        public static string filename;
        protected void CreateItem(object sender, EventArgs e)
        {
            string fileName = "";
            string fileType = "";
            if (FileUpload1.HasFile)
            {
                FileSelected = true;

                filename = Path.GetFileName(FileUpload1.PostedFile.FileName);


                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + FileUpload1.FileName + " - " + GetFileSizeString(FileUpload1.FileBytes.Length) + " - " + System.IO.Path.GetExtension(FileUpload1.FileName) + "');", true);
                fileName = FileUpload1.FileName;
                fileType = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (filename.Length != 0)
                {


                    string contentType = FileUpload1.PostedFile.ContentType;

                    using (Stream fs = FileUpload1.PostedFile.InputStream)
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            byte[] bytes = br.ReadBytes((Int32)fs.Length);
                            Data = bytes;

                        }
                    }
                }



            }

            if (FileSelected)
            {
                BBAALL.UploadFile(Data, RecordID, fileName, fileType);
                FileSelected = false;
            }
           Files.RecordID = RecordID;
            Response.Redirect("Files.aspx");


        }
        public string GetFileSizeString(int size)
        {


            if (size / 1024 == 0)
            {

                return size + " - Byte";

            }
            else if (size / 1024 / 1024 == 0)
            {

                return size / 1024 + " - KB";

            }
            else if (size / 1024 / 1024 / 1024 == 0)
            {

                return size / 1024 / 1024 + " - MB";

            }
            return size + "";
        }
        protected void Return(object sender, EventArgs e)
        {


            Files.RecordID = RecordID;

             Response.Redirect(ReturnToPage + ".aspx");



        }
    }
}