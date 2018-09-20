using Euchre.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre.Games
{
    class EuchreGame : IGame
    {
        private const int NUM_OF_PLAYERS = 4;
        private int playersTurn = -1;
        private string userName;
        private Dealer dealer;

        public List<Player> players = new List<Player>();

        public EuchreGame()
        {
            dealer = new Dealer();
            userName = AskUserName();
        }

        public void Start()
        {
            Setup();
            StartRound();
        }

        private void StartRound()
        {
            DealHands();
        }

        private void DealHands()
        {
            dealer
        }

        private void BuildPlayers()
        {
            var isAI = false;
            for (int i = 0; i < NUM_OF_PLAYERS; i++)
            {
                var player = new Player() { Number = i, IsComputer = isAI, Hand = new List<Card>()};
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

        private void Setup()
        {
            DeckSetup();
            BuildPlayers();
            SetTurn();
        }

        private void DeckSetup()
        {
            for (int i = 0; i < Dealer.Deck.Count; i++)
            {
                if (Dealer.Deck[i].number < 8 && Dealer.Deck[i].number != 0)
                {
                    Dealer.Deck.RemoveAt(i);
                    i--;
                }
            }
            dealer.Shuffle();
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

        private string AskUserName()
        {
            Console.WriteLine("What is Your Name?");
            return Console.ReadLine();
        }

        //Deals Cards to each player. 
        //First Player to recieve a Jack is the starting dealer.
        private void StartTurn()
        {
            var count = 1;
            while (true)
            {              
                var card = dealer.Deal();
                if (card.number == 10)
                {
                    playersTurn = count % NUM_OF_PLAYERS;
                    dealer.Shuffle();
                    break;
                }
                count++;
            }
        }
    }
}
