using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Teacher:Employee
    {
        public Teacher(string fullname):base(fullname)
        {

        }
        
        public byte ExperienceYear;

        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age} - Position: {Position} - Experience: {ExperienceYear}");
        }

    }
}
