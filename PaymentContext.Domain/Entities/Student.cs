using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.Entities
{
    class Student
    {
        private IList<Subscription> _subscrition;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscrition.ToArray(); } }

        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
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
