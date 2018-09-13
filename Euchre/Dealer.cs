using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    class Dealer
    {
        private const int DECK_SIZE = 24;

        public Card[] Deck = new Card[DECK_SIZE];

        public void NewDeck()
        {
            const int CARDS_PER_SUIT = 6;
            var count = 0;

            var numberOfSuits = Enum.GetValues(typeof(Card.Suit)).Length;

            for (int i = 0; i < numberOfSuits; i++)
            {
                for (int j = 0; j < CARDS_PER_SUIT; j++)
                {
                    var card = new Card()
                    {
                        number = j,
                        suit = (Card.Suit)i
                    };
                    Deck[count] = card;
                    count++;
                }
            }
        }

        public void Shuffle()
        {

        }
    }
}
