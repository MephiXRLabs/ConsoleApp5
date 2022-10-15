using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            Console.WriteLine(Calc.Add(a, b) + " " + Calc.numOfIterations);
            Console.ReadKey();
        }
    }

    public class Calc
    {

        public static int numOfIterations = 68;
        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

    }
}
