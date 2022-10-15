using System;

namespace ClassLibrary4
{
    public abstract class Animal
    {
        public string name;

        public abstract void Move();


        public virtual void Talk()
        {
            Console.WriteLine("Voice");
        }
    }
}
