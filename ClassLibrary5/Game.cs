using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary5
{
    public class Game
    {

        IPositionable[] _positionable; 

        public Game()
        {
            _positionable = new IPositionable[2] {new Shelf(), new Lever() };
        }

        public void SetManually(int x1, int y1, int x2, int y2)
        {
            _positionable[0].SetPositionInWorld(x1, y1);
            _positionable[1].SetPositionInWorld(x2, y2);
        }

        public IInteractable CheckHit(int x, int y)
        {
            foreach (var item in _positionable)
            {

                if (item is IInteractable && item.CheckPosition(x, y))
                {
                    var interactable = item as IInteractable;
                    return interactable;
                }
            }
            Console.WriteLine("Empty Field");
            return null;
        }


    }
}
