using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Employee:Human
    {
        public Employee(string fullname):base(fullname)
        {

        }

        public string Position;

        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age} - Position: {Position}");
        }
    }
}
