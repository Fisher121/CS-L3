using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.models
{
    class acceptCash : CashModel
    {
        public void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }
    }
}
