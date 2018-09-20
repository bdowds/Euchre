using System;
using Xunit;
using Euchre;

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
    }
}
