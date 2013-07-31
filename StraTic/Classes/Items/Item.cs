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
        }

        int Mod_Accuracy
        {
            get;
        }

        int Mod_Attack
        {
            get;
        }

        int Mod_Defense
        {
            get;
        }

        int Mod_Health
        {
            get;
        }

        int Mod_Move
        {
            get;
        }

        int Mod_Range_Min
        {
            get;
        }

        int Mod_Range_Max
        {
            get;
        }

        int Name
        {
            get;
        }

        int Points
        {
            get;
        }
    }
}
