using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car lamba = new Car();

            Engine uazEngine = new Engine();
            Wheel[] wheels = new Wheel[6] { new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f) };
            Car uaz = new Car(uazEngine, wheels);
        }
    }

    public class Car
    {
        public Engine engine;
        public Wheel[] wheels;

        public Car()
        {
            engine = new Engine();
            wheels = new Wheel[] { new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f), new Wheel(16.0f) };
        }

        public Car(Engine engine, Wheel[] wheels)
        { 
            this.engine = engine;
            this.wheels = wheels;
        }
    }

    public class Engine
    {
        
    }

    public class Wheel
    {
        float radius;

        public Wheel(float radius)
        {
            this.radius = radius;
        }
    }
}
