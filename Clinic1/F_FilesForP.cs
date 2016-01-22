using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Web;

namespace Clinic1
{
    public partial class F_FilesForP : Form
    {
        public F_FilesForP()
        {
            InitializeComponent();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //using (SqlConnection cn = new SqlConnection("CONNECTION STRING"))
            //{
            //    cn.Open();
            //    FileStream fStream = File.OpenRead("C:\\MyFiles\\TempReport.pdf");
            //    byte[] contents = new byte[fStream.Length];
            //    fStream.Read(contents, 0, (int)fStream.Length);
            //    fStream.Close();
            //    using (SqlCommand cmd = new SqlCommand("insert into SavePDFTable " + "(PDFFile)values(@data)", cn))
            //    {
            //        cmd.Parameters.Add("@data", contents);
            //        cmd.ExecuteNonQuery();
            //    }
            //}
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

            TxtFilePath.Text = openFileDialog.FileName;

            byte[] chosenFile = System.IO.File.ReadAllBytes(TxtFilePath.Text);

            string strQuery = "insert into tblFiles(ID, PDFFILE, comments) values (@pID, @file, @Comments)";
            SqlCommand cmd = new SqlCommand(strQuery);

           
            cmd.Parameters.Add("@pID", SqlDbType.Int).Value = "301187795";/////////////////
            cmd.Parameters.Add("@file", SqlDbType.VarBinary).Value = chosenFile;
            cmd.Parameters.Add("@comments", SqlDbType.VarChar).Value = TxtfileName.Text;

            InsertUpdateData(cmd);

        }

    }
}

//to read the data:
 
//protected void Button2_Click(object sender, EventArgs e)
//        {
//            string ToSaveFileTo = Server.MapPath("~\\File\\Report.pdf");  
                        
//            using (SqlConnection cn = new SqlConnection("CONNECTION STRING"))
//            {
//                cn.Open();
//                using (SqlCommand cmd = new SqlCommand("select PDFFile from SavePDFTable  where ID='" + "1" + "' ", cn))
//                {
//                    using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.Default))
//                    {
//                        if (dr.Read())
//                        {
                          
//                            byte[] fileData = (byte[])dr.GetValue(0);
//                            using (System.IO.FileStream fs = new System.IO.FileStream(ToSaveFileTo, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite))
//                            {
//                                using (System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs))
//                                {
//                                    bw.Write(fileData);
//                                    bw.Close();
//                                }
//                            }
//                        }

//                        dr.Close();
//                        Response.Redirect("~\\File\\Report.pdf");
//                    }
//                }
//            }
//        }
//    }
//}
