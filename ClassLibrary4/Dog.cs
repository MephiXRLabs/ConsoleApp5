using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary4
{
    public class Dog : Animal
    {
        public override void Move()
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Bark");
        }
    }
}
