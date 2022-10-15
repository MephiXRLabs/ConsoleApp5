using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary3
{
    public class Class8 : Class7
    {
        public string str2;
        /*public Class8()
        {
            Console.WriteLine("Class8");
        }*/

        public Class8(string str, string str2) : base(str)
        {
            this.str2 = str2;
        }
    }
}
