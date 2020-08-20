using System;


namespace Sanch.Interface
{
    class Cyborg : ICar, IPerson
    {
        /* public int Move(int distance) // одной реализацией два интерфейса сразу (не явно)
         {
             return distance / 200;
         }*/
        int ICar.Move(int distance) // с указанием интерфейса (явно)
        {
            return distance / 100;

        }

        int IPerson.Move(int distance) // с указанием интерфейса (явно)
        {
            return distance / 5;
        }
    }
}
