using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _01_Binary_Serializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car(1,"audi",3.7);
            Car audi1 = new Car(2,"audi",2.0);
            Car audi2 = new Car(3,"audi",2.7);
            Car audi3 = new Car(4,"audi",3.1);

            List <Car> list= new List<Car>();
            list.Add(audi);
            list.Add(audi1);
            list.Add(audi2);
            list.Add(audi3);
            Console.WriteLine(audi);
            string path = "../../../car.dat";
            BinaryFormatter bf = new BinaryFormatter();
            using(FileStream fs = new FileStream(path,FileMode.Create))
            {
                bf.Serialize(fs, list);
                fs.Position = 0;
                List<Car> readL = (List<Car>)bf.Deserialize(fs);
                    Console.WriteLine($"______Deserialized Car_____\n");
                foreach (var item in readL)
                {
                    Console.WriteLine($"{item}");

                }

            }





        }
    }
}
