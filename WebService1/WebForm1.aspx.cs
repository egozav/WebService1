using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GetTime webService = new GetTime();
            List<int> lstIntegers = new List<int> { 5, 6, 7 };
            Label1.Text = "Output of WebService: " + webService.Add(lstIntegers).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GetTime webService = new GetTime();
            Label2.Text = "Output of WebService: " + webService.GetDate().ToString();
        }
    }
}