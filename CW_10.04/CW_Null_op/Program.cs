using System;

namespace CW_Null_op
{
    class Program
    {
        void DemoRecover(object ob)
        {
            if(ob.GetType()==typeof(int))
            {
                int value = (int)ob;
                Console.WriteLine($"Unboxxing obj --> int{value}");
            }
            else if (ob.GetType() == typeof(double))
            {
                var value = (double)ob;
                Console.WriteLine($"Unboxxing obj --> double{value}");
            }
            else if (ob is string)
            {
                var value = (string)ob;
                Console.WriteLine($"Unboxxing obj --> string{value}");
            }
            else
                Console.WriteLine($"Another type {ob}");


        }
        static void Main(string[] args)
        {
            //string str = "Demo line";
            //Console.WriteLine($"String : {str??"Undefined"}");
            //Console.WriteLine($"Substing(0,4)= '{str.Substring(0, 4)}");

            //string str1 = null;
            //Console.WriteLine($"String : {str1 ?? "Undefined"}");
            //Console.WriteLine($"Substing(0,4)= '{str1?.Substring(0, 4)}");


            //Console.WriteLine();
            //int[] arr = { 100, 20, 30, 45, 555,};
            //Console.WriteLine($"Array lenght = {arr.Length}");
            //Console.WriteLine($"1 element= {arr[0]}");
            //Console.WriteLine();
            //arr = null;
            //Console.WriteLine($"Array lenght = {arr?.Length}");
            //Console.WriteLine($"1 element= {arr?[0]}");



            ////arr ??= new int[10];
            ////Console.WriteLine($"\nArray lenght = {arr?.Length}");
            //int value = 100;
            //Nullable<int> a = null;
            ////a = 200;
            //int? b = null;
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //if(b!=null)
            //    Console.WriteLine($"b.Value = {b.Value}");

            //int? sum = a + b;
            //int? product = value * a;
            //Console.WriteLine($"a + b = {sum}");
            //Console.WriteLine($"Value * a = {product}");

            //int avg = (a.GetValueOrDefault() + b.GetValueOrDefault()+value) / 3;
            //Console.WriteLine($"Avg* a = {avg}");
            //int product3 = a.GetValueOrDefault(1) * b.GetValueOrDefault(1) * value;
            //Console.WriteLine($"Product from 3 numbers = {product3}");
            //if (a.HasValue && b.HasValue)
            //{
            //    int sum3 = (int)(a + b + value);
            //    Console.WriteLine($"Sum of 3 = {sum3}");
            //}


            int value = 122;
            object o = value;
            Console.WriteLine($"o = {o}\t type = {o.GetType().Name}");
            int value2 = (int)o;

            double valueD = 56.67;
            o = valueD;
            Console.WriteLine($"o = {o}\t type = {o.GetType().Name}");
            
            string valueStr = "Hello";
            o = valueStr;
            Console.WriteLine($"o = {o}\t type = {o.GetType().Name}");

            Console.WriteLine("__________________________Demo method_________");
            DemoRecover;


        }
    }
}
