using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp_Configuration
{
    public partial class Sample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            txtSample1.Text = ConfigurationManager.AppSettings["a"];
            txtSample2.Text = ConfigurationManager.AppSettings["b"];
        }
    }
}