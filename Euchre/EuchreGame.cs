using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    class EuchreGame : IGame
    {
        private const int NUM_OF_PLAYERS = 4;
        private Dealer dealer;

        public List<Player> players { get; set; }

        public EuchreGame(Dealer _dealer)
        {
            dealer = _dealer;
        }

        public void Setup()
        {
            for (int i = 0; i < Dealer.Deck.Count; i++)
            {
                if (Dealer.Deck[i].number < 8 && Dealer.Deck[i].number != 0)
                {
                    Dealer.Deck.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Start()
        {

        }


        private void BuildPlayers()
        {
            var isAI = false;
            for (int i = 0; i < NUM_OF_PLAYERS; i++)
            {
                var player = new Player() { IsComputer = isAI };
                players.Add(player);
                isAI = true;
            }
        }
    }
}
