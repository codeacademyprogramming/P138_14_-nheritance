using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Notebook:Product
    {
        public Notebook(string brand):base(brand)
        {
        }
        public Notebook(string brand,string model) : base(brand,model)
        {
        }
        public int RAM;
    }
}
