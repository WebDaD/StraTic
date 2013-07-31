using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public abstract class Skill
    {
        public SkillType SkillType
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }

        public abstract int Value
        {
            get;
            set;
        }

        public abstract int callSkill(Unit target);
    }
}
