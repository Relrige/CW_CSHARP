using System;
using System.IO;

namespace CW_29._05
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string fname = "info.dat";
            using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            {
                int value =100;
                double valueD = 12.45;
                string str = "Hello Привіт";
                DateTime now = DateTime.Now;

                bw.Write(value);
                bw.Write(valueD);
                bw.Write(str);
                bw.Write(now.ToString());

                int[] arr = { 10, -20, 30, 40, 50, 88, 77 };
                bw.Write(arr.Length);
                foreach(var item in arr)
                {
                    bw.Write(item);
                }
                ConsoleColor backColor = ConsoleColor.Blue;
                ConsoleColor foreColor = ConsoleColor.Red;
            }
            using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
            {
                int value =br.ReadInt32();
                double valueD =br.ReadDouble();
                string str = br.ReadString();

                string dateStr = br.ReadString();
                DateTime date = DateTime.Parse(dateStr);

                Console.WriteLine($"Int = {value}");
                Console.WriteLine($"Double = {valueD}");
                Console.WriteLine($"String = {str}");
                Console.WriteLine($"Date= {date}");

                int[] arr = new int[br.ReadInt32()];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = br.ReadInt32();
                }
                foreach (var item in arr)
                {
                    Console.WriteLine($"{item,5}");
                }
                ConsoleColor backColor = (ConsoleColor)br.ReadInt32();
                ConsoleColor foreColor = Enum.Parse<ConsoleColor>(br.ReadString());
                Console.BackgroundColor = backColor;
                Console.ForegroundColor = foreColor;
                Console.WriteLine("Demo");
            }

        }
    }
}
