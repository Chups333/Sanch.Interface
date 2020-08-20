using System;


namespace Sanch.Interface
{
    class LadaSeven : ICar // имплиментирует интерфейсы и не один, а несколько можно
    {
        public int Move(int distance) // реализуем метод интерфейса именно тут, а не в интерфейсе
        {
            return distance / 40;
        }
    }
}
