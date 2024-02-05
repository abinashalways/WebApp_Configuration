using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApp_Configuration
{
    public partial class Sample2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {          
            SqlConnection Con =new SqlConnection(ConfigurationManager.AppSettings["SqlCon"]);
            string Query = "Select * from Empdetails";          
            SqlDataAdapter DA = new SqlDataAdapter(Query,Con);
            DataSet DS=new DataSet();
            DA.Fill(DS,"Emp");
            GridView1.DataSource = DS.Tables[0];         
            GridView1.DataBind();
        }
    }
}