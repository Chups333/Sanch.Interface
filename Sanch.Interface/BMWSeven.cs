using System;

namespace Sanch.Interface
{
    class BMWSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
