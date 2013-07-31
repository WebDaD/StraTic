using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public abstract class WinningConditions
    {
        public WinningTypes WinningType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract Boolean isVictory();

        public WinningConditions load()
        {
            throw new System.NotImplementedException();
        }
    }
}
