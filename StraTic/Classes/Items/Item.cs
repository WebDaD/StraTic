using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public interface Item
    {
        int ID
        {
            get;
            set;
        }

        int Mod_Accuracy
        {
            get;
            set;
        }

        int Mod_Attack
        {
            get;
            set;
        }

        int Mod_Defense
        {
            get;
            set;
        }

        int Mod_Health
        {
            get;
            set;
        }

        int Mod_Move
        {
            get;
            set;
        }

        int Mod_Range_Min
        {
            get;
            set;
        }

        int Mod_Range_Max
        {
            get;
            set;
        }

        int Name
        {
            get;
            set;
        }

        int Points
        {
            get;
            set;
        }

        Item load(int id);
    }
}
