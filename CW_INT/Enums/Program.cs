using System;

namespace Enums
{
    class Program
    {
        enum Color : byte {White=1,Blue,Green,Red,Yellow }
        
        static void Main(string[] args)
        {
            Color color = Color.Green;
            Console.WriteLine($"Color {color} Number {(byte)color}");

            color = (Color)4;
            Console.WriteLine($"Color {color} Number {(byte)color}");
            
            Console.WriteLine("\n Enter color(White = 1,Blue =2, Green,Red,Yellow)");

            if (Enum.TryParse<Color>(Console.ReadLine(),true, out color))
            {
                if (Enum.IsDefined<Color>(color))
                    Console.WriteLine($"Entered color {color} = {(byte)color}");
                else
                    Console.WriteLine("Error does not exist");
            }
            else
                Console.WriteLine("error");

            string[] names = Enum.GetNames(typeof(Color));
            Console.WriteLine("\n..........Names of colors");
            foreach(var name in names)
            {
                Console.WriteLine($"{ name,20}");
            }

            Color[] colors= Enum.GetValues<Color>();
            Console.WriteLine("\n..........Values of colors");
            foreach (var name in colors)
            {
                Console.WriteLine($"{ name,20} ");
            }
        }
    }
}
