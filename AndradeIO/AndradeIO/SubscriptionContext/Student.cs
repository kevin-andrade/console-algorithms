using AndradeIO.SharedContext;
using AndradeIO.NotificationContext;
using System;


namespace AndradeIO.SubscriptionContext
{
    public class Student : Base
    {
        public Student() {
            Subscriptions = new List<Subscription>();
        }

        public  User User { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subscription) {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "Student already has an active subscription."));
            }

            Subscriptions.Add(subscription);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
