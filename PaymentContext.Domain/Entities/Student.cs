using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subcriptions;
        public Student(Name name, Document document, Email email,Address address)
        {
            Name = name;
            Document = document;
            Email = email;
            Address = address;
            _subcriptions = new List<Subscription>();
        
            AddNotifications(name);
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Address { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subcriptions.ToArray();} }

        public void AddSubscription(Subscription subscription){
            foreach (var item in Subscriptions)
            {
                item.Activate();
            }
        }
    }
}