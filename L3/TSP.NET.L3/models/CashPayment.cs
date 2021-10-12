using System;

namespace TSP.NET.L3.models
{
    class CashPayment : PaymentModel
    {
        public override void BuyTicket(TicketDetails ticket, PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
           acceptCash cash = new acceptCash();
            cash.AcceptCash(ticket);

           DispenseCash dispense = new DispenseCash();
            dispense._cashAccepted = cash._cashAccepted;
            dispense.DispenseChange(ticket, onPayChangeToMobilePhone);
        }
    }
}
