using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    class Card
    {
        public enum Suit { Spade, Club, Heart, Diamond };

        public int number { get; set; }
        public Suit suit { get; set; }
    }
}
