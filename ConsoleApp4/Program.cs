using ClassLibrary3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class5 class5 = new Class5();
            Class6 class6 = new Class6();


            class5.Str = "1";
            class6.Str = "2";

            class5.Foo();
            class6.Foo();

            //Class7 class7 = new Class7();
            //Class8 class8 = new Class8();
            Class9 class9 = new Class9();
            Class10 class10 = new Class10();

            class9.Foo();

            class10.Foo();
            Console.ReadKey();
        }
    }
}
