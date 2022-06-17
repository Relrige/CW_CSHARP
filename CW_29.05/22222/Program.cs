using System;
using System.IO;

namespace _22222
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../../my.txt";
            //CreatTxtFile();
            ShowFileLast(path);
        }
        private static void ShowFileByLine(string path)
        {
            Console.WriteLine("__File");
            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                int i = 0;
                while (line!=null)
                {
                    Console.WriteLine($"");

                }
                string content = sr.ReadLine();
            }
        }
        private static void ShowFileLast(string path)
        {
            Console.WriteLine("__File");
            using (StreamReader sr = new StreamReader(path))
            {
                string content = sr.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        private static void CreatTxtFile(string path)
        {
            

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string line;
                Console.WriteLine("Enter Line");
                line = Console.ReadLine();
                sw.WriteLine(line);
                Random mrnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    sw.Write($"{mrnd.Next(100),5}");
                }
            }
        }
    }
}
