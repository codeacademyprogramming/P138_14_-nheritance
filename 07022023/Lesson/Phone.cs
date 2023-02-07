using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Phone:Product
    {
        public Phone(string brand,string model):base(brand,model)
        {

        }
        public byte SimCount;
    }
}
