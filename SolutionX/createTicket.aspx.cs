using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolutionX.DomainEntities;
using SolutionX.BussinesLayer;

namespace SolutionX
{
    public partial class createTicket : System.Web.UI.Page
    {
        ticketBussines ticketBussines=new ticketBussines();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void send_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.idCostumer = 1;
            t.description = detail.Value;

            ticketBussines.CreateTicket(t);
        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            detail.Value = null;
            companyId.Value = null;

        }
    }
}