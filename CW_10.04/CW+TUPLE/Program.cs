using System;
using System.Linq;
namespace CW_TUPLE
{
    class Program
    {
        static(int min,int max,double avg) MinMax(params int[] arr)
        {
            return (arr.Min(), arr.Max(), arr.Average());
        }
        static (int numbOfDodatn, double SumDrob, int numbOfstring) Method1(params object[] arr)
        {
            int numbDodat = 0;
            double sum = 0;
            int numbofstr = 0;
            for (int i = 0; i < arr.Length; i++)
            {   
                switch(arr[i])
                {
                    case int:
                        if((int)arr[i]>0)
                        {
                            numbDodat++;
                        }
                        break;
                    case double :
                        if ((double)arr[i] > 0)
                        {
                            numbDodat++;
                        }
                        sum +=(double) arr[i];
                        break;
                    case string:
                        numbofstr++;
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
            return (numbDodat, sum, numbofstr);
        }
        static void Main(string[] args)
        {
            //Tuple<int, string> t = new Tuple<int, string>(10, "ten");
            //Console.WriteLine($"Tuple<> ::: {t.Item1}, {t.Item2}");

            //var t2 = t.ToValueTuple();
            //Console.WriteLine($"ValueTuple ::: {t2.Item1}, {t2.Item2}");
            //t2.Item1 = 100;
            //t2.Item2 = "1 hundred";
            //Console.WriteLine($"Can change ValueTuple :::{t2.Item1}, {t2.Item2}");

            //t = (5, "five").ToTuple();
            //Console.WriteLine(t2);

            //(string name, int price) t3 = ("bread", 22);
            //Console.WriteLine(t3);
            //Console.WriteLine($"Name : {t3.name} Price : {t3.price}");

            //int[] arr = {1,2,100};
            //var result = MinMax();
            //Console.WriteLine(result);

            object[] arr2 = { 10, 2.3,4.7,34, "stra","asd", true };
            var result2 = Method1(arr2);
            //Console.WriteLine(result2);
            Console.WriteLine($"Number of dodatnii :{result2.numbOfDodatn}, sum of double : {result2.SumDrob}, numer of string : {result2.numbOfstring}");

        }
    }
}
