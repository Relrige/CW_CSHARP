using System;
using System.IO;

namespace New_CW
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path;
            //Console.WriteLine("enter folder path");
            //path = Console.ReadLine();
            //PrintFolder(path);


            Directory.SetCurrentDirectory(@"E:\");
            Directory.CreateDirectory("TEST");
            Directory.SetCurrentDirectory(@"E:\TEST");
            Directory.CreateDirectory("A");
            Directory.CreateDirectory("B");
            string fname = "first.txt";
            Console.WriteLine("\n\t\tEnter text  : ");
            File.WriteAllText(fname, Console.ReadLine());
            string str1 = @"A\firstA.txt";
            if (File.Exists(str1))
            {
                Console.WriteLine($"File  already  exist");
            }
            else
                File.Copy(fname, str1);


            string str2 = @"B\firstB.txt";
            if (File.Exists(str2))
            {
                Console.WriteLine($"File  already  exist");
            }
            else
                File.Copy(fname, str2);



            Console.WriteLine("____A___");
            Console.WriteLine(File.ReadAllText(str1));
            FileInfo fi = new FileInfo(str1);
            Console.WriteLine($"Creation time :{fi.CreationTime}");
            Console.WriteLine($"Lenght :{fi.Length}");


            Console.WriteLine("____B___");
            Console.WriteLine(File.ReadAllText(str2));
            FileInfo fi1 = new FileInfo(str2);
            Console.WriteLine($"Creation time :{fi1.CreationTime}");
            Console.WriteLine($"Lenght :{fi1.Length}");
        }
        static void PrintFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
            {
                Console.WriteLine($"Error : folder {path} not found");
                return;
            }
            foreach (FileInfo f in di.EnumerateFiles())
            {
                string info = "<DIR>";
                if (f.Attributes.HasFlag(FileAttributes.Directory))
                    info = (f as FileInfo)?.Length.ToString()??"";
                Console.WriteLine($"{f.Name,-40} {f.CreationTime,-20} {info}");
            }
        }
    }
}
