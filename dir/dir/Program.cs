using System;
using System.IO;
using System;
using System.Collections.Generic;

namespace dir
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Current path :{Directory.GetCurrentDirectory()}");
            
            string dirPath = "VPD 121";
            if(Directory.Exists(dirPath))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                DirectoryInfo dir1 = Directory.CreateDirectory(dirPath);
                Console.WriteLine(dir1.Exists);
            }
            string fname;
            Console.WriteLine("Enter name of file");
            fname=Console.ReadLine();
            string pathFname = Path.Combine(dirPath, fname);
            Console.WriteLine($"Will be created file {pathFname}");

            Console.WriteLine("Enter content ");
            File.WriteAllText(pathFname, Console.ReadLine());

            List<string> lines = new List<string> { "]n C# Files", "class fsfasasf" };
            File.AppendAllLines(pathFname, lines);

            FileInfo fi = new FileInfo(pathFname);
        }
    }
}
