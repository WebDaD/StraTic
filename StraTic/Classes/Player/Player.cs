using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public abstract class Player
    {
        public String Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public List<Unit> Units
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public PlayerType PlayerType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
