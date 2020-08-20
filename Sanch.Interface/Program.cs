using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new LadaSeven());
            cars.Add(new BMWSeven());
            // в список вложили одну и туже команду но разнгого выполнения и 

            foreach(var car in cars)
            {
                Console.WriteLine(car.Move(200)); // один интерфейс! хотя к классу могут имплиминтироваться несколько интерфейсов! Концентрация к одному интерфейсу !
            }
            Cyborg cyb = new Cyborg();
            //cyb. - нет Move ! нужно привести !!!
            ((ICar)cyb).Move(100); // привели и получилось определить метод Move
            ((IPerson)cyb).Move(100);
            Console.ReadKey();
        }
    }
}
