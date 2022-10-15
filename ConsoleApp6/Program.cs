using ClassLibrary4;
using ClassLibrary5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.SetManually(0, 1, 1, 1);
            Console.WriteLine("Enter coordinates");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            var interactable = game.CheckHit(x, y);
            if (interactable != null)
            {
                interactable.Interact();
            }
            Console.ReadKey();
        }
    }
}
