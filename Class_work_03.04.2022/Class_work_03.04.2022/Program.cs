using System;
using System.Text;
using System.Linq;

namespace Jugged_Arrays
{
    class Program
    {
        static void PrintJugged<T>(T[][] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    Console.Write($"{m[i][j],-15}");
                }
                Console.WriteLine();
            }
        }
        static void AddRow<T>(ref T[][] m, params T[] line)
        {
            Array.Resize(ref m, m.Length + 1);
            m[m.Length + 1] = line;
        }
        static void SwapLines<T>(T[][] m, int row1, int row2)
        {
            if (!IsValidRow(row1) || !IsValidRow(row2))
            { return; }

            T[] tmp = m[row1];
            m[row1] = m[row2];
            m[row2] = tmp;
            bool IsValidRow(int r) => r >= 0 && r < m.Length;
        }
        static void CreateJugged(out int[][] arr, params int[] len)
        {
            arr = new int[len.Length][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[len[i]];
            }
        }
        static void Revers(ref int[][] m)
        {
            for (int i = 0; i < m.GetLength(0)-1; i++)
            {
                int[] temp= m[i];
                m[i] = m[m.Length-1-i];
                m[m.Length - 1 - i] = temp;
            }
        }
        static void Main(string[] args)
        {
            //const int rows = 3;
            //string[][] words = new string[rows][]
            //{
            //    new string[2]{"Orange","some"},
            //    new [] { "word","tree"},
            //    new [] { "mouse","lines"}
            //};

            //PrintJugged(words); ;

            //SwapLines(words, 0, 1);
            //PrintJugged(words); ;
            //AddRow(ref words, new string[] { "cherry", "berry", "banana" });
            ////AddRow(ref words, "apple", "road", "computer");
            //Console.WriteLine();
            //PrintJugged(words);
            //int[][] aa;
            //CreateJugged(out aa,1, 2, 3, 4,5,6);
            //PrintJugged(aa);
            //Revers(ref aa);
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //PrintJugged(aa);

            //Demostr();
            //DemoCmp();
            //DemoSearch();
            DemoSplitJoin();
        }

        private static void DemoSplitJoin()
        {
            string str = "Sfasf asfas f g pltp kgktpotpgp ";
            string[] tokens =str.Split("\t!-,".ToCharArray());

            foreach (string t in tokens)
            {
                Console.WriteLine($"{t,30}");
            }
        }

        private static void DemoSearch()
        {
            string str = "fksafasA FSkkf f akpsfok oasjsf joajoso";
            char letter = 'o';
            int index = str.IndexOf(letter);
            if(index!=-1)
            {
                Console.WriteLine($"Letter found in {index}");
                Console.WriteLine($"Letter found in {str.LastIndexOf(letter)}");
            }
            string symbols = ",-.!";
            int index1 = str.IndexOfAny(symbols.ToCharArray());
            if (index != -1)
            {
                Console.WriteLine($"Letter found in {index}");
                //Console.WriteLine($"Letter found in {str.LastIndexOf(letter)}");
            }
            

        }

        private static void DemoCmp()
        {
            Console.WriteLine("Enter first str");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second str");
            string str2 = Console.ReadLine();
            bool result = str1 == str2;
            Console.WriteLine($"{str1} == {str2} ::: {result}");

            result = str1 != str2;
            Console.WriteLine($"{str1} != {str2} ::: {result}");

            int res = str1.CompareTo(str2);
            Console.WriteLine($"Compare ::: {res}");

            res = String.CompareOrdinal(str1,str2);
            Console.WriteLine($"String.CompareOriginal ::: {res}");

            res = String.Compare(str1, str2,true);
            Console.WriteLine($"String.CompareOriginal ::: {res}");
        }
        private static void Demostr()
        {
            Console.OutputEncoding = Encoding.Unicode;
            string str = "house car flint";
            char[] arr = str.ToCharArray();
            arr[0] = char.ToUpper(arr[0]);
            str = new string(arr);
            Console.WriteLine(arr);
            //str = str + "fsafasf a";
            //str = String.Concat(str, "fa sda sfadfdfafdfdcxt", 12, true);
            //Console.WriteLine(str);

            //Console.WriteLine("Insert");
            //string newStr = str.Insert(6, "fsafas");
            //Console.WriteLine(newStr);

            //Console.WriteLine("Replace");
            //newStr = str.Replace("o", "*");
            //Console.WriteLine(newStr);
        }
    }
}
