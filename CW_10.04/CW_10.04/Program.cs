using System;

namespace CW_10._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"__________Last Id____{Footballer.LastId}");
            Footballer pl1 = new Footballer();
            pl1.Name = "Messi";
            pl1.Goals = 700;
            pl1.Team = "PSG";
            Console.WriteLine(pl1);

            Footballer pl2 = new Footballer()
            {
                Name = "Muller",
                Team = "Bavaria",
                Goals = 130
            };
            Footballer pl3 = new Footballer()
            {
                Name = "a",
                Team = "Bavaria",
                Goals = 130
            };
            Console.WriteLine(pl2);

            Console.WriteLine($"Compare goals {pl1.Name} and {pl2.Name} ={Footballer.CompareByGoals(pl1,pl2)}"); ;
            Console.WriteLine($"Compare goals {pl2.Name} and {pl3.Name} ={Footballer.CompareByGoals(pl2, pl3)}"); ;
            //Console.WriteLine($"Compare goals {pl.Name} and {pl2.Name} ={Footballer.CompareByGoals(pl1,pl2)}"); ;
        }
    }
}
