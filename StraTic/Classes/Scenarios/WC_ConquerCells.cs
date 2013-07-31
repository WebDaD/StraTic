using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class WC_ConquerCells : WinningConditions
    {
        private List<Cell> cells;
        private Player player;
        private Dictionary<Cell,bool> conquered;

        public WC_ConquerCells(Player player, List<Cell> cells)
        {
            throw new System.NotImplementedException();
        }
    
        public override bool isVictory()
        {
            foreach (Cell x in cells)
            {
                conquered[x] = x.hasUnit(player);
            }
            if (conquered.ContainsValue(false)) return false;
            else return true;
        }
    }
}
