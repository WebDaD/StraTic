using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class WC_Survive : WinningConditions
    {
        private int rounds;
        private Game game;

        public WC_Survive(Game game, int rounds)
        {
            this.game = game;
            this.rounds = rounds;
        }
    
        public override bool isVictory()
        {
            if (rounds >= game.Current_Round) return true;
            else return false;
        }
    }
}
