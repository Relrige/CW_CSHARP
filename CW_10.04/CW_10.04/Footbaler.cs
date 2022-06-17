using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_10._04
{
    class Footballer
    {
        private string name= "Noname";
        private static int lastId;
        public readonly int Id= ++lastId;

        public string Name {
            get => name;
            set => name = value ?? "Noname";
        }
        public string Team{ get; set; } = "Noteam";

        public uint Goals { get; set; }
        
        public static int LastId => lastId;
        static Footballer()
        { lastId = new Random().Next(0, 5);
            Console.WriteLine("__________Static ctor______");
        }
        public override string ToString()
        {
            return $"Id : {Id,-5} Footballer : {Name,-12}, Team : {Team,-10}, Goals : {Goals,-10}";
        }
        public static int CompareByGoals(Footballer p1, Footballer p2)
        {
            //if (p1.Goals == p2.Goals)
            //    return 0;
            //if (p1.Goals > p2.Goals)
            //    return 1;
            //return -1;

            return p1.Goals.CompareTo(p2.Goals);
        }
    }
}
