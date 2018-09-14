using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euchre
{
    class Dealer
    {
        private const int DECK_SIZE = 24;

        public List<Card> Deck = new List<Card>();

        public Dealer()
        {
            Shuffle();
        }


        public Card Deal()
        {
            if (!isEmpty())
            {
                var topCard = Deck[0];
                Deck.RemoveAt(0);
                return topCard;
            }
            return null;
        }

        public void Shuffle()
        {
            NewDeck();
            Random rnd = new Random();
            Deck = Deck.OrderBy(x => rnd.Next()).ToList();
        }

        private bool isEmpty()
        {
            if (Deck.Count <= 0)
                return true;
            return false;
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
                default:
                    value = "Not_Implemented";
                    break;
            }
            return $"{value} of {card.suit}s";
        }


        private void NewDeck()
        {
            const int CARDS_PER_SUIT = DECK_SIZE / 4;

            var numberOfSuits = Enum.GetValues(typeof(Card.Suit)).Length;
            Deck = new List<Card>();

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
                    Deck.Add(card);
                }
            }
        }

    }
}
