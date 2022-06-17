using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    delegate void FewFuelHandler(Car car, string message);
    class MyArgs :EventArgs
    {
        public string Message { get; set; }
    }
    class Car
    {
        const int fastSpent = 2;
        const int midSpent = 1;
        const int lowFuel = 5;
        private int fuel;
        //public event FewFuelHandler FewFuel;
        public event EventHandler<MyArgs> FewFuel;
        public string Brand { get; set; }
        public int Fuel 
        {  
            get=>fuel;
            set
            {
                fuel = value >= 0 ? value : 0;
                if(fuel<=lowFuel)
                {
                    MyArgs args = new MyArgs() { Message = "Attention"}
                    FewFuel?.Invoke(this,args);
                }
            }
        }

        public Car(string brand = "Nobrand", int fuel =50)
        {
            Brand = brand;
            Fuel = fuel;
        }
        public override string ToString()
        {
            return $"Car : '{Brand}' \t Fuel : {Fuel}";
        }
        public void GoFast(int km)
        {
            Console.WriteLine($"Fast trip {km} km, need spent {km * fastSpent} ");
            Fuel -= km * fastSpent;
        }
        public void GoMid(int km)
        {
            Console.WriteLine($"Fast trip {km} km, need spent {km * midSpent} ");
            Fuel -= km * midSpent;
        }
    }
}
