using AndradeIO.SharedContext;
using System;

namespace AndradeIO.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
