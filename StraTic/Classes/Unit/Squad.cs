using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class Squad : Unit
    {
        public int POS_X
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

        public int POS_Y
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

        public int POS_Z
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

        /// <summary>
        /// Accuracy, calculated as average from all soldiers
        /// </summary>
        public int Accuracy
        {
            get
            {
                double val = 0;
                foreach (Soldier s in Soldiers)
                {
                    val += s.Accuracy;
                }
                return (int)(val / Soldiers.Count);
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

        public bool MoveTo(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public int AttackUnit(Unit target)
        {
            throw new NotImplementedException();
        }


        public string Image
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


        public List<Skill> Skills
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

        /// <summary>
        /// Performs the selected Skill on a Target
        /// </summary>
        /// <param name="skill">Skill to Use</param>
        /// <param name="target">Target Unit</param>
        /// <returns>Final Value</returns>
        public int performSkill(Skill skill, Unit target)
        {
            return skill.callSkill(target);
        }

        public Squad(Database database, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
