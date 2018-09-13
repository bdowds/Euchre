using System;

namespace Euchre
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new Dealer();
            dealer.NewDeck();

            Console.WriteLine(dealer.Deck[0].suit);
            Console.ReadLine();
        }
    }
}
