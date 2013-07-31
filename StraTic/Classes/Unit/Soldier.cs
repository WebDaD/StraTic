using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class Soldier
    {
        private int base_accuracy;

        public Soldier(Database database, int id)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Final Accuracy. Calculated by summing base_accuracy, armor and weapon mods
        /// </summary>
        public int Accuracy
        {
            get
            {
                return base_accuracy + Armor.Mod_Accuracy + MainWeapon.Mod_Accuracy;
            }
        }

        public int Attack
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Defense
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Health_Current
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Health_Max
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Move
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Points
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Range_Max
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int Range_Min
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public List<Soldier> Soldiers
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Health
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Defense
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Points
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Accuracy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Attack
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Range_Min
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Range_Max
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Base_Move
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int XP
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Weapon MainWeapon
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Weapon SecondWeapon
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Armor Armor
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
