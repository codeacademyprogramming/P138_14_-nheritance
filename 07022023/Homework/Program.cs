using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var nt1 = new Notebook("Asus", "Rog",1200,16);

            Console.WriteLine("Notebook count:");
            int count = Convert.ToInt32(Console.ReadLine());

            Notebook[] notebooks = new Notebook[count];

            //Notebook nt1 = new Notebook("Lenovo", "IdeaPad") { Price = 2200, RAM = 16 };

            //notebooks[0] = nt1;
            //notebooks[1] = new Notebook("Dell", "XPS 15") { Price = 2500, RAM = 16 };
            //notebooks[2] = new Notebook("Acer", "E55") { Price = 1800, RAM = 8 };
            //notebooks[3] = new Notebook("Asus", "ROG") { Price = 2800, RAM = 32 };

            for (int i = 0; i < count; i++)
            {
                Console.Write("Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Model: ");
                string model = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.Write("RAM: ");
                int ram = Convert.ToInt32(Console.ReadLine());

                Notebook nt = new Notebook(brand, model) { Price = price, RAM = ram };
                notebooks[i] = nt;
            }

            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
            }

            var result = sum / notebooks.Length;
            Console.WriteLine(result);
        }
    }
}
