using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Animal cat = new Cat { name = "Barsik"};
            Animal dog = new Dog { name = "Bobik"};


            Cat cat1 = new Cat { name = "Marquiz" };
            Animal anim = cat1;
            Animal anim1 = new Animal();

            Cat cat2 = anim1 as Cat;
            if (cat2 == null)
            {
                Console.WriteLine("False");
            }
            else Console.WriteLine("True");


            Zoo zoo = new Zoo();

            if (cat is Animal animal1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            

            zoo.PutAnimalToCage(cat);
            zoo.PutAnimalToCage(dog);
            Console.ReadKey();
        }
    }


    class Animal
    {
        public string name;

        public virtual void Move()
        {
            
        }

        public virtual void Talk()
        {
            Console.WriteLine("Voice");
        }
    }

    class Cat : Animal
    {
        public override void Move()
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Moew");
        }
    }

    class Dog : Animal
    {
        public override void Move()
        {

        }

        public override void Talk()
        {
            Console.WriteLine("Bark");
        }
    }

    class Zoo
    {
        Cat cat;
        Dog dog;

        public void PutAnimalToCage(Animal animal)
        {
            animal.Talk();
        }
    }
}
