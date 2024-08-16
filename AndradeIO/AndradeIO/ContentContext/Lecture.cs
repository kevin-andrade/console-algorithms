using AndradeIO.SharedContext;
using System;

namespace AndradeIO.ContentContext
{
    public class Lecture : Base
    {
        public Lecture()
        {
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
