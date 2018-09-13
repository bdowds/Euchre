using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euchre
{
    class Dealer
    {
        private const int DECK_SIZE = 24;

        public Card[] Deck = new Card[DECK_SIZE];

        public Dealer()
        {
            NewDeck();
        }


        //public Card Deal()
        //{

        //}

        public void Shuffle()
        {
            Random rnd = new Random();
            Deck = Deck.OrderBy(x => rnd.Next()).ToArray();
        }


        private static string NameCard(Card card)
        {
            string value = "";

            switch(card.number)
            {
                case 0:
                    value = "Ace";
                    break;
                case 1:
                    value = "Nine";
                    break;
                case 2:
                    value = "Ten";
                    break;
                case 3:
                    value = "Jack";
                    break;
                case 4:
                    value = "Queen";
                    break;
                case 5:
                    value = "King";
                    break;
            }
            return $"{value} of {card.suit}s";
        }


        private void NewDeck()
        {
            const int CARDS_PER_SUIT = DECK_SIZE / 4;
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
                    card.name = NameCard(card);
                    Deck[count] = card;
                    count++;
                }
            }
        }

    }
}
