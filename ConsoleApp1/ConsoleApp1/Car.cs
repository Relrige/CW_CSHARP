using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Binary_Serializer
{
    [Serializable] // маємо  вказати такий атрибут для нашоготипу, який дозволяємо  серіалізувати
    class Engine
    {
        public double Power { get; set; }
        public Engine(double power)
        {
            Power = power;
        }
        public override string ToString()
        {
            return $"Engine power : {Power}";
        }
    }
    [Serializable] // атрибут позначає  можливість серіалізувати об'єкт типу Car
    class Car
    {
        //[NonSerialized] // не потірбно серіалізувати
        private int id = -1; // приватні поля теж  серіалізуються 
        
       // [NonSerialized]
        private string brand = "Unknown";
        public Car(int id, string brand, double power)
        {
            Brand = brand;
            Engine = new Engine(power);
            this.id = id;
        }
        public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
        public Engine Engine { get; set; }
        public override string ToString()
        {
            return $"Id {id}.\tCar brand {Brand ?? "NoBrand"}.\t{Engine}.";
        }
    }
}
