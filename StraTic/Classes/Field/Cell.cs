using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class Cell
    {
        private int x;
        private int y;
        private int z;
        private CellType type;

        public Cell(int x, int y, int z, CellType t)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.type = t;
        }
    
        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public int Z
        {
            get
            {
                return z;
            }
        }

        public CellType Type
        {
            get
            {
                return type;
            }
        }
    }
}
