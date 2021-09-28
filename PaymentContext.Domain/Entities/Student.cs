using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    class Student : Entity
    {
        private IList<Subscription> _subscrition;

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscrition.ToArray(); } }

        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscrition = new List<Subscription>();
        }

        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Inactivate();

            _subscrition.Add(subscription);
        }
    }
}
