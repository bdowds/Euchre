using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre.Models
{
    class Card
    {
        public enum Suit { Spade, Heart, Diamond, Club };

        public int number { get; set; }
        public string name { get; set; }
        public Suit suit { get; set; }
    }
}
