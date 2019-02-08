using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolutionX.DomainEntities;


namespace SolutionX
{
    public partial class createTicket : System.Web.UI.Page
    {
         

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_Click(object sender, EventArgs e)
        {

            string detailT=detail.Value;
            
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            detail.Value = null;
            companyName.Value = null;
        }
    }
}