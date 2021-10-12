using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L3.models
{
    class DispenseCash : CashModel
    {
        public void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price && !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        private bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }
    }
}
