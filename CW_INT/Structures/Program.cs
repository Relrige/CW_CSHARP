using System;

namespace Structures
{
    class Program
    {
        static void Change(ref Dish d)
        {
            int energy;
            Console.WriteLine($"\n Enter energy for {d.Name} ");
            if(int.TryParse(Console.ReadLine(),out energy) && energy>=0)
            {
                d.Energy = energy;
            }

        }
        static void Main(string[] args)
        {
            Dish dish = new Dish("Piza", Category.Pizza, 100);
            Console.WriteLine(dish);

            Change(ref dish);
            Console.WriteLine(dish);

            Dish clone = dish;
            Console.WriteLine(clone);
            Console.WriteLine($"Equals : {dish.Equals(clone)}");
            clone.Energy++;
            Console.WriteLine($"Equals : {dish.Equals(clone)}");

            int val1 = 222, val2 = 333, val3 = 222;
            Console.WriteLine("______________");
            Console.WriteLine($"{val1} ? {val2} = {val1.CompareTo(val2)}");
            Console.WriteLine($"{val1} ? {val3} = {val1.CompareTo(val3)}");
            Console.WriteLine($"{val2} ? {val1} = {val3.CompareTo(val2)}");
            
        
        }
    }
}
