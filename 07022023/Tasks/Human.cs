using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Human
    {
       
        public Human(string fullname)
        {
            FullName = fullname;
        }

        public string FullName; 
        public byte Age;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age}");
        }
    };
}
