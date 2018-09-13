using System;

namespace Euchre
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new Dealer();
            dealer.Shuffle();

            //var firstCard = dealer.Deck[0];
            //Console.WriteLine($"Card: {firstCard.number} {firstCard.suit}");
            var count = 1;
            foreach(var card in dealer.Deck)
            {
                Console.WriteLine($"Card: {card.name}");
                count++;
            }
            Console.ReadLine();
        }
    }
}
