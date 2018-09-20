using System;
using System.Collections.Generic;
using System.Text;

namespace Euchre
{
    interface IGame
    {
        void Setup();
        void Start();
        void BuildPlayers();
    }
}
