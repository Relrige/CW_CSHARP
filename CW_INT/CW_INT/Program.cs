using System;

namespace CW_INT
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(12345,10_000);
            //Console.WriteLine(card);
            //card.Pay(3_000);
            //Console.WriteLine($"Balance {card.Balance}");

            GoldCard gold = new GoldCard(3333, 30_000, 22222);
            gold.Pay(1000);
            Console.WriteLine($"Balance {gold.Balance}");

            Card[] cards = { card, gold };
            foreach (var c in cards)
            {
                c.Pay(1000);
            }

        }
    }
}
