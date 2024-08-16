using AndradeIO.ContentContext;
using AndradeIO.SubscriptionContext;
using System;
using System.Collections.Generic;

namespace AndradeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //var articles = new List<Article>();
            //articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            //articles.Add(new Article("Artigo sobre C#", "csharp"));
            //articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var courses = new List<Course>();
            var courseOop = new Course("fundamentos oop", "fundamentos-oop");
            var courseCsharp = new Course("fundamentos c#", "fundamentos-csharp");
            var courseAspNet = new Course("fundamentos asp.net", "fundamentos-aspnet");
            courses.Add(courseOop);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            //foreach (var course in courses)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(course.Id);
            //    Console.WriteLine(course.Title);
            //    Console.WriteLine(course.Url);
            //}

            var careers = new List<Career>();
            var careerDotnet = new Career("Epecialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);

            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem3);

            careers.Add(careerDotnet);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"title: {item.Course?.Title}");
                    Console.WriteLine($"level: {item.Course?.Level}");
                    Console.WriteLine();

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                var student = new Student();
                var payPal = new PayPalSubscription();

                student.CreateSubscription(payPal);
            }
        }
    }
}