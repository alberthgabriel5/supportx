using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SolutionX.BussinesLayer;
using SolutionX.DomainEntities;

namespace SolutionX
{
    public partial class listTicket : System.Web.UI.Page
    {
        ticketBussines ticketBussines = new ticketBussines();
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Ticket> list = ticketBussines.ViewTicket();
            foreach (Ticket tic in list)
            {
                TableRow r = new TableRow();
                
                for (int i = 0; i < 4; i++)
                {
                    TableCell c = new TableCell();
                    if (i == 0)
                    {
                        c.Controls.Add(new LiteralControl(tic.idCode + ""));
                        r.Cells.Add(c);
                    }
                    else if (i == 1)
                    {
                        c.Controls.Add(new LiteralControl(tic.stateTicket + ""));
                        r.Cells.Add(c);
                    }
                    else if (i == 2)
                    {
                        c.Controls.Add(new LiteralControl(tic.dateCreate + ""));
                        r.Cells.Add(c);
                    }
                    else if (i == 3)
                    {
                        c.Controls.Add(new LiteralControl(tic.idCostumer + ""));
                        r.Cells.Add(c);
                    }

                }



                Table1.Rows.Add(r);
            }
        }
    }
}