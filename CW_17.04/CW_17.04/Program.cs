using System;

namespace CW_17._04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray a = new MyArray();
            a.Add(100);
            a.Add(200);
            a.Add(300);
            Console.WriteLine(a.ToString());
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}]= {a[i]} ");
            }


        }
    }
}
