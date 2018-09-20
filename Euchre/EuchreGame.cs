using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    class EuchreGame : IGame
    {
        private const int NUM_OF_PLAYERS = 4;
        private int playersTurn = -1;
        private string userName;
        private Dealer dealer;

        public List<Player> players { get; set; }

        public EuchreGame(Dealer _dealer, string _userName)
        {
            dealer = _dealer;
            userName = _userName;
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


        public void BuildPlayers()
        {
            var isAI = false;
            for (int i = 0; i < NUM_OF_PLAYERS; i++)
            {
                var player = new Player() { Number = i, IsComputer = isAI };
                if(!isAI)
                {
                    player.Name = userName;
                }
                else
                {
                    player.Name = $"COM {i}";
                }
                players.Add(player);
                isAI = true;
            }
        }

        private void SetTurn()
        {
            if (!isGameStarted())
            {
                StartTurn();
                return;
            }
            playersTurn++;
            playersTurn %= NUM_OF_PLAYERS;
        }

        private bool isGameStarted()
        {
            if (playersTurn == -1)
            {
                return false;
            }
            return true;
        }

        //Deals Cards to each player. 
        //First Player to recieve a Jack is the starting dealer.
        private void StartTurn()
        {
            while(true)
            {
                var count = 1;
                var card = dealer.Deal();
                if (card.number == 10)
                {
                    playersTurn = count % NUM_OF_PLAYERS;
                }
                count++;
            }
        }
    }
}
