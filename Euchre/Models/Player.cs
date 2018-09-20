using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre.Models
{
    class Player
    {
        public List<Card> Hand { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public bool IsComputer { get; set; }

    }
}
