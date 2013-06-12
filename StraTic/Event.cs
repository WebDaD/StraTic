using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public abstract class Event
    {
        public EventType EventType
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Name
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public abstract bool fire();
    }
}
