using System;
using Xunit;
using Euchre;
using Euchre.Models;
using System.Collections.Generic;

namespace Euchre.Tests
{
    public class DealerTests
    {
        [Fact]
        public void DeckShouldHave52Cards()
        {
            // Arrange
            Dealer dealer = new Dealer();
            int expected = 52;

            // Act
            int actual = Dealer.Deck.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EmptyDeckShouldDealNull()
        {
            // Arrange
            Dealer dealer = new Dealer();
            Dealer.Deck.RemoveAll(x => x != null);
            Card expected = null;

            // Act
            Card actual = dealer.Deal();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DealingShouldReduceDeckCardCountByOne()
        {
            // Arrange
            Dealer dealer = new Dealer();
            int expected = Dealer.Deck.Count - 1;

            // Act
            int prior = Dealer.Deck.Count;
            Card dealtCard = dealer.Deal();
            int actual = Dealer.Deck.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DealingAfter52DealsShouldDealNull()
        {
            // Arrange
            Dealer dealer = new Dealer();
            Card expected = null;

            // Act
            for (int i = 0; i < 52; i++)
            {
                dealer.Deal();
            }
            Card actual = dealer.Deal();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeckAfter52DealsShouldBeEmpty()
        {
            // Arrange
            Dealer dealer = new Dealer();
            int expected = 0;

            // Act
            for (int i = 0; i < 52; i++)
            {
                dealer.Deal();
            }
            int actual = Dealer.Deck.Count;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShufflingShouldChangeCardOrder()
        {
            // Arrange
            Dealer dealer = new Dealer();
            List<Card> beforeShuffling = new List<Card>();
            foreach(Card card in Dealer.Deck)
            {
                beforeShuffling.Add(card);
            }
            bool sameOrder = true;

            // Act
            dealer.Shuffle();
            for(int i = 0; i < Dealer.Deck.Count; i++)
            {
                if (beforeShuffling[i] != Dealer.Deck[i])
                {
                    sameOrder = false;
                    break;
                }
            }

            // Assert
            Assert.False(sameOrder);
        }

        [Fact]
        public void DealtCardShouldHaveName()
        {
            // Arrange
            Dealer dealer = new Dealer();
            dealer.Shuffle();

            // Act
            string name = dealer.Deal().name;

            // Assert
            Assert.True(name.Length > 0);
        }
    }
}
