using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2001, 10, 20, 14,30,0);
            date = DateTime.Now;
          

            date = date.AddYears(-20);


            Console.WriteLine(date.Date);
            Console.WriteLine(date);
            Console.WriteLine(date.ToString("dddd-MMMM-yyyy HH:mm"));
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);
            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine(date.DayOfYear);
            Console.WriteLine(date.Hour);
            Console.WriteLine(date.Minute);

            Console.WriteLine("Tarixi daxil edin:");
            string dateStr = Console.ReadLine();
            DateTime dateInput = Convert.ToDateTime(dateStr);
            Console.WriteLine(dateInput.DayOfWeek);

            if (dateInput > DateTime.Now)
            {
                Console.WriteLine("Gelecek tarixdir");
            }
            else
            {
                Console.WriteLine("Gelecek tarix deyil");
            }

            if(dateInput.Date == DateTime.Now.Date)
            {
                Console.WriteLine("Bugundur");
            }








            Notebook nt = new Notebook("ASUS","ROG")
            {
                Model = "ROG",
                Price = 1800,
                RAM = 16
            };

            Phone pn = new Phone("Apple","11")
            {
                Price = 1200,
                SimCount = 1
            };

            nt.ShowInfo();
            pn.ShowInfo();
        }
    }
}
