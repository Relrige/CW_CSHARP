using System;

namespace CW_22._05
{
    class Program
    {
        static void Main(string[] args)
        {
            Action a1 = Hello;
            a1();

            Action<string, int> a2 = (string s, int i) => Console.WriteLine($"String : {s}, Number : {i}");

            Func<int, int, int, double> fun1 = Area;
            Console.WriteLine($"Fun 1 : {fun1(3, 4, 5)}");
            Console.WriteLine($"Fun 1 : {fun1(1, 1, 1)}");

            Func<int,int ,double> fun2 = (int a, int b) => (a + b) / 2.0;

            Predicate<string> hasLetter= (string s)=> s.Contains('a');
            string str1 = "Design";
            string str2 = "Programming";
            Console.WriteLine($"\nHasLetter A {str1} = {hasLetter(str1)}");
            Console.WriteLine($"\nHasLetter A {str2} = {hasLetter(str2)}");

            void Hello() => Console.WriteLine("_______Hello____");
            double Area(int a,int b,int c)
            {
                double p = (a + b + c) / 2.0;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }

        }
    }
}
