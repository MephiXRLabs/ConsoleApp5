using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary4
{
    public class Zoo
    {
        Cat cat;
        Dog dog;

        public void PutAnimalToCage(Animal animal)
        {
            animal.Talk();
        }
    }
}
