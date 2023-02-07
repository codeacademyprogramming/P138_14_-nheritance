using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Student:Human
    {
        public Student(string fullname):base(fullname)
        {

        }

        public byte Point;

        public override void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age} - Point: {Point}");
        }
    }
}
