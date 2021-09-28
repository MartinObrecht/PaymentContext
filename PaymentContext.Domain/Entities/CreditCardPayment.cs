﻿using PaymentContext.Domain.ValueObjects;
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

        public CreditCardPayment(
            string cardHolderName, 
            string cardNumber, 
            string lasTransactionNumber, 
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string payer,
            Document document,
            Address address,
            Email email) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                payer,
                document,
                address,
                email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LasTransactionNumber = lasTransactionNumber;
        }
    }
}
