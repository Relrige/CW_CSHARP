using System;

namespace RefEqauls
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 2, 3 };
            int[] arr2 = { 10, 2, 3 };
            int[] arr3 = arr1;

            Console.WriteLine($"ref arr1 and arr2 = {Object.ReferenceEquals(arr1, arr2)}");
            Console.WriteLine($"ref arr1 and arr3= {Object.ReferenceEquals(arr1, arr3)}");

            Console.WriteLine($"Equals arr1 and arr3 = {Object.Equals(arr1, arr3)}");
            Console.WriteLine($"Equals arr1 and arr3 = {Object.Equals(arr1, arr2)}");

            DateTime dt = new DateTime(2022, 4, 10);
            DateTime dt2 = DateTime.Today;
            Console.WriteLine(dt);
            Console.WriteLine(dt2);
            Console.WriteLine($"Equals data= {Object.Equals(dt, dt2)}");

        }
    }
}
