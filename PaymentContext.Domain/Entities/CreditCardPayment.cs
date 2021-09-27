using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LasTransactionNumber { get; private set; }

        public CreditCardPayment(string cardHolderName, string cardNumber, string lasTransactionNumber)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LasTransactionNumber = lasTransactionNumber;
        }
    }
}
