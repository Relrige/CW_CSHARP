using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    //class Driver
    //{
    //    public string Name { get; set; }
    //    public void Refuel(Car car, string message)
    //    {
    //        Console.WriteLine($"Driver {Name} notified about '{message}' ");
    //        car.Fuel += 50;
    //        Console.WriteLine(car);
    //    }

    //}
    class Driver
    {
        public string Name { get; set; }
        public void Refuel(object obj, EventArgs args)
        {
            Car car = obj as Car;
            Console.WriteLine($"Driver {Name} notified about  ");
            Console.WriteLine(car);
            Console.WriteLine("Before refuel+10");
            car.Fuel += 10;
            Console.WriteLine("After refuel+10");
            Console.WriteLine(car);

        }

    }
}
