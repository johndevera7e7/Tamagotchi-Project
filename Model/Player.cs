using System;
using System.Collections.Generic;
using System.Text;

namespace Tamagotchi.Model
{
    public class Player
    {
        private const string NAME = "No player name.";
        private string Name { get; set; }

        public Player (string name)
        {
            this.Name = name;
        }

        public Player()
        {
            this.Name = NAME;
        }
    }
}
