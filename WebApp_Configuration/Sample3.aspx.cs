using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;

namespace WebApp_Configuration
{
    public partial class Sample3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
           // ConnectionStringSettings C= new ConnectionStringSettings();
           // C = ConfigurationManager.ConnectionStrings["SqlCon"];
            SqlConnection Con=new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
            string Query = "Select * from Empdetails";
            SqlCommand Cmd =new SqlCommand(Query,Con);
            Cmd.CommandType=CommandType.Text;
            SqlDataAdapter DA= new SqlDataAdapter(Cmd);
            DataSet DS= new DataSet();
            DA.Fill(DS,"Emp");
            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();
        }
    }
}