using System;
using System.Collections;

namespace CW_15._05
{
    class Greeting
    {
        static public void Hello(string str)
        {
            Console.WriteLine($"Hello, {str}");
        }
        static public void GoodDay(string str)
        {
            Console.WriteLine($"Good day, {str}");
        }
        static public void GoodEvn(string str)
        {
            Console.WriteLine($"Good Eveaning, {str}");
        }

    }
    class Chat
    {
        public string First { get; set; }
        public string Second{ get; set; }
        public void SendMessage(string message);

        public void SendMessageFS(string message)
        {
            Console.WriteLine($"{First} send to {Second} : ");
        }

    }
    class Program
    {
        delegate void MyDeleg(string str);
        static void Main(string[] args)
        {
            //DEmoArr();

            MyDeleg del = Greeting.Hello;
            Console.WriteLine($"Method = {del.Method} Tage = {del.Target}");
            del.Invoke("Ivan");
            del("olesa");
            del = null;
            del?.Invoke("Mykola");
            Console.WriteLine();
            del = (MyDeleg)Greeting.Hello + Greeting.GoodDay;
            del += Greeting.GoodEvn;
            del("Anna");

        }

        private static void DEmoArr()
        {
            ArrayList a1 = new ArrayList()
            {
                100,"program","database",4.5,890,true
            };
            a1.Add("smth");
            a1.AddRange(new object[] { 34.55, -90 });
            a1.InsertRange(1, new object[] { false, "table", 111 });

            Print(a1, "_________List_________");
            a1.RemoveAt(0);
            a1.RemoveRange(a1.Count - 3, 3);
            Print(a1, "_________List_________");
        }

        private static void Print(ArrayList a1,string text ="")
        {
            Console.WriteLine(text);
            foreach (var e in a1)
            {
                Console.WriteLine($"{e,20} ");
            }
        }
    }
}
