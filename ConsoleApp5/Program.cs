using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(4.5f);

            animal.ApplyDamamge(5.5f);

            Animal owl = new Animal("Bubo", "bubo");
            Console.WriteLine(owl.Name);

            Animal animal1 = new Animal { Name = "Dolphin"};
            Console.WriteLine(animal1.Name);
            
            Console.ReadKey();  

        }
    }

    /*------ОПРЕДЕЛЕНИЕ КЛАССОВ------*/
    /*<модификатор_доступа> class <имя_класса>
     * {
     *      <члены_класса>
     * }
     * 
     */


    /*---------Модификаторы доступа----------*/
    /*  private - Доступ только внутри собственного класса.
     *  public - Доступ из любого места кода.
     *  internal - Доступ только в пределах сборки.
     *  protected - Доступ в пределах класса и в производных классах. Производные классы могут находиться в других сборках
     *  private protected - Доступ в пределах класса и в производных классах. Но внутри одной сборки
     *  protected internal - Доступ внутри текущей сборки и из производных классов внутри других сборок
     */

    class Animal
    {
        string name;
        string surname;

        public string Name { set { name = value; } get { return name + " " + surname; } } // $"{name} {surname}"
        int age;


        float healthPoint;
        public float HealthPoint 
        { get { return healthPoint; }

          set {
                if (value < 0)
                    healthPoint = 0;
            } 
        }


        float weight;

        public Animal()
        {
            
        }

        public Animal(string name, int age, float healthPoint, float weight)
        {
            this.name = name;
            this.age = age;
            HealthPoint = healthPoint;
            this.weight = weight;
        }

        public Animal(float hp)
        {
            HealthPoint = hp;
        }


        public Animal(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }
        public void ApplyDamamge(float damage)
        {
            HealthPoint -= damage;
            Console.WriteLine("Health point:" + HealthPoint);
        }
        void Move()
        {

        }

        void MakeSound()
        {
            
        }


    }
}
