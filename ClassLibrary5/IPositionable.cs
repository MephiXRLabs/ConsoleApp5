using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary5
{
    public  interface IPositionable
    {
        void SetPositionInWorld(int x, int y);
        bool CheckPosition(int x, int y);
    
    }
}
