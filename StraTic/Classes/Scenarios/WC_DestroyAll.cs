using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class WC_DestroyAll : WinningConditions
    {
        private Player enemy;
    
        public override bool isVictory()
        {
            if (enemy.Units.Count > 0) return false;
            else return true;
        }

        public WC_DestroyAll(Player enemy)
        {
            this.enemy = enemy;
        }
    }
}
