using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class WC_DestroyUnits : WinningConditions
    {
        private List<Unit> units;

        public WC_DestroyUnits()
        {
            throw new System.NotImplementedException();
        }
    
        public override bool isVictory()
        {
            int ch = 0;
            foreach (Unit u in units)
            {
                ch += u.Health_Current;
            }
            if (ch > 0) return false;
            else return true;
        }
    }
}
