using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    class EuchreGame : IGame
    {
        private Dealer dealer;

        public EuchreGame(Dealer _dealer)
        {
            dealer = _dealer;
        }

        public void Setup()
        {
            for(int i = 0; i < Dealer.Deck.Count; i++)
            {
                if(Dealer.Deck[i].number < 8 && Dealer.Deck[i].number != 0)
                {
                    Dealer.Deck.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Start()
        {

        }
    }
}
