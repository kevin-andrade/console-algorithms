using AndradeIO.SharedContext;
using AndradeIO.NotificationContext;
using System;

namespace AndradeIO.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
        {
            if (course == null)
            {
                AddNotification(new Notification("Course", "course invalid"));
            }

            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}