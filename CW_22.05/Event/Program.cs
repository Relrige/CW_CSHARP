using System;

namespace Event
{
    class Program
    {

        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            Driver driver = new Driver { Name = "Ivan" };

            car.FewFuel += driver.Refuel;
            car.GoMid(20);
            Console.WriteLine(car);

            car.GoFast(20);
            Console.WriteLine(car);

        }
    }
}
