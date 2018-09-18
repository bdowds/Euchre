using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euchre
{
    class Dealer
    {
        private const int DECK_SIZE = 52;

        public static List<Card> Deck = new List<Card>();
        private static List<Card> Pile = new List<Card>();

        public Dealer()
        {
            NewDeck();
        }

        public Card Deal()
        {
            if (!isEmpty())
            {
                var topCard = Deck[0];
                Deck.RemoveAt(0);
                ToPile(topCard);
                return topCard;
            }
            return null;
        }

        public void Shuffle()
        {
            while(Pile.Count > 0)
            {
                Deck.Add(Pile[0]);
                Pile.RemoveAt(0);
            }
            Random rnd = new Random();
            Deck = Deck.OrderBy(x => rnd.Next()).ToList();
        }

   
        private bool isEmpty()
        {
            if (Deck.Count <= 0)
                return true;
            return false;
        }

        private void ToPile(Card card)
        {
            Pile.Add(card);
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
                    value = "Two";
                    break;
                case 2:
                    value = "Three";
                    break;
                case 3:
                    value = "Four";
                    break;
                case 4:
                    value = "Five";
                    break;
                case 5:
                    value = "Six";
                    break;
                case 6:
                    value = "Seven";
                    break;
                case 7:
                    value = "Eight";
                    break;
                case 8:
                    value = "Nine";
                    break;
                case 9:
                    value = "Ten";
                    break;
                case 10:
                    value = "Jack";
                    break;
                case 11:
                    value = "Queen";
                    break;
                case 12:
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
