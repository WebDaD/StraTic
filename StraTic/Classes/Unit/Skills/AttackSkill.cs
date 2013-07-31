using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class AttackSkill : Skill
    {
        private int value;
        public override int Value { get { return value; } }

        /// <summary>
        /// Reduzes the Targets Health_Current for the Value value
        /// </summary>
        /// <param name="target">Target to Attack</param>
        /// <returns>damage done</returns>
        public override int callSkill(Unit target)
        {
            target.Health_Current += value; 
            return value;
        }

        /// <summary>
        /// Load Skill From Database. Type = attack, Table = skills
        /// </summary>
        /// <param name="database"></param>
        /// <param name="id"></param>
        public AttackSkill(Database database, int id)
        {

        }
    }
}
