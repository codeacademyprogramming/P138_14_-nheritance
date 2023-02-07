using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Product
    {
        public Product(string brand)
        {
            Brand = brand;
        }
        public Product(string brand,string model)
        {
            Brand = brand;
            Model = model;
        }
        public string Brand;
        public string Model;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }
    }
}
