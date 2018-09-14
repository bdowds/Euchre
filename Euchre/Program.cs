using System;

namespace Euchre
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new Dealer();
            dealer.Shuffle();


            ////Tests Dealer without Deal Method
            //var count = 1;
            //foreach (var card in dealer.Deck)
            //{
            //    Console.WriteLine($"Card: {card.name}-------{count}");
            //    count++;
            //}
            //
            //Console.WriteLine($"\nFirstCard: {dealer.Deck[0].name}");

            //Tests Dealer with Deal Method
            for (int i = 0; i < 53; i++)
            {
                var nextCard = dealer.Deal();
                if (nextCard != null)
                    Console.WriteLine($"Card: {nextCard.name}-------{i+1}");
                else
                    Console.WriteLine("No More Cards");
            }

            Console.ReadLine();
        }
    }
}
