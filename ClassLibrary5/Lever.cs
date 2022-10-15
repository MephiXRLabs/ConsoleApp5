using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary5
{

    public class Lever : IInteractable, IPositionable
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
            /*проиграть анимацию поворота*/
            Console.WriteLine("Playing lever animation");
        }

        public void SetPositionInWorld(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}
