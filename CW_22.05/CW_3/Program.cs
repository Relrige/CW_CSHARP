using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using scq = System.Collections.Generic;

namespace CW_3
{
    class Program
    {
        class DB :IDisposable
        {
            string nameDB;
            bool isOpen = false;

            FileStream fs = new FileStream("some", FileMode.Create);

            public DB()
            {

            }

            public void Open(string name)
            {
                this.nameDB = name;
                isOpen = true;
                WriteLine($"DB { nameDB} HashCode opened");
            }




        }
        static void Main(string[] args)
        {
            string path = "my.dat";
            using (FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write))
            {


            }



        }
    }
}
