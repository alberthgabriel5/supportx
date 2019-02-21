using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SolutionX.login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButttonCLick(object sender, EventArgs e) {
            string user = username.Value;
            string pass = password.Value;
            Console.WriteLine(user + "g" + pass);
        }
        
    }
}