using System;

namespace TSP.NET.L3.models
{
    class CardPayment : PaymentModel
    {
        public override void BuyTicket(TicketDetails ticket, PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            ChargeCard(ticket, payment);
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }
    }
}
