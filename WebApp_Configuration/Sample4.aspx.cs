using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Configuration
{
    public partial class Sample4 : System.Web.UI.Page
    {
        string Query,FName,Extension,Path; Byte[] Data; SqlCommand Cmd; SqlConnection Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                     
        }
        protected void btnGet_Click(object sender, EventArgs e)
        {
            Query = "Select * From FilesData Where FileId=@P1";
            {
                Cmd = new SqlCommand(Query, Con);
                Cmd.Parameters.AddWithValue("@P1", txtEID.Text);
                Con.Open();
                SqlDataReader DR = Cmd.ExecuteReader();
                if (DR.Read())
                {
                    Data = (byte[])DR[3];
                    Image1.ImageUrl = "Data:image/jpeg;base64," + Convert.ToBase64String(Data);
                    txtEName.Text = DR[1].ToString();
                    lblDisplay.Text = "Image Loaded Successfully";
                }
                else
                {
                    lblDisplay.Text = "No Record Found";
                }
                Con.Close();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = null;txtEName.Text = null;
            int Index1 = FileUpload1.FileName.LastIndexOf("\\") + 1;//31+1=32
            //"C:\Users\abina\OneDrive\Desktop\IMG_1182.jpg"
            int Index2 = FileUpload1.FileName.LastIndexOf(".");//40
            FName = FileUpload1.FileName.Substring(Index1, Index2 - Index1);//(32,8) 
            //index1 value count to 8 wii be IMG_1182
            Extension = FileUpload1.FileName.Substring(Index2 + 1);   //all the values from index2 i.e. '.' onwards
           
            Stream fileStream = FileUpload1.PostedFile.InputStream;
            MemoryStream memoryStream = new MemoryStream();              
                    fileStream.CopyTo(memoryStream);
                    Data = memoryStream.ToArray();
           // Data = File.ReadAllBytes(FileUpload1.FileName);
                         lblDisplay.Text= "Image Submittted Successfully";
            Query = "Insert Into FIlesData Values(@P1,@P2,@P3,@P4)";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", txtEID.Text);
            Cmd.Parameters.AddWithValue("@P2", FName);
            Cmd.Parameters.AddWithValue("@P3", Extension);
            Cmd.Parameters.AddWithValue("@P4", Data);
            Con.Open();
            Cmd.ExecuteNonQuery();
            Con.Close();
        }
    }
}