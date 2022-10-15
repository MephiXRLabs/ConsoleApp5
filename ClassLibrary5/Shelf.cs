using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary5
{
    public class Shelf : Container, IInteractable, IPositionable
    {
        int _x, _y;

        public bool CheckPosition(int x, int y)
        {
            if (_x == x && _y == y)
                return true;
            return false;
        }

        public void Interact()
        {
            /*Проиграть анимацию открытия*/
            Console.WriteLine("Playing shelf animation");

        }


        public void SetPositionInWorld(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public override void Store()
        {
            Console.WriteLine("Store Items");
        }
    }
}
