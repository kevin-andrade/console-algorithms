using AndradeIO.NotificationContext;
using System;

namespace AndradeIO.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Guid Id { get; set; }

        public Base() {
            Id = Guid.NewGuid();
        }
    }
}
