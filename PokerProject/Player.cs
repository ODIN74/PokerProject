using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerProject
{
    public class Player
    {
        private string name;
        private uint stack = 1000;
        private bool button;
        private uint currentBet;

        public Player()
        { }

        public Player(string name, bool button)
        {
            this.name = name;
            this.button = button;
        }

        public string Name
        {
            get { return name; }
        }

        public bool Button 
        {
            get { return button; }
            set { button = value; }
        }

        public uint Stack
        {
            get { return stack; }
            set { stack = value; }
        }

        public uint CurrentBet
        {
            set { currentBet = value; }
        }

        public void IncreaseStack (uint bank)
        {
            this.stack += bank;
        }

        public void ReductionStack (ref uint currentBet)
        {
            this.stack -= currentBet;
        }

    }
}
