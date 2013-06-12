using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public interface Unit
    {
        /// <summary>
        /// Position (x) on Field
        /// </summary>
        /// <value>0- game.Field.width</value>
        int POS_X
        {
            get;
        }

        /// <summary>
        /// positition(y) on the Field
        /// </summary>
        /// <value>0-game.Field.height</value>
        int POS_Y
        {
            get;
        }

        /// <summary>
        /// Position (z) on the Field
        /// </summary>
        /// <remarks>
        /// Layer of the Field:
        /// -1 = Underground
        /// 0 = Ground
        /// 1 = Air
        /// 2 = Orbit
        /// 3 = Space
        /// </remarks>
        /// <value>-1 to 3</value>
        int POS_Z
        {
            get;
        }

        /// <summary>
        /// Does the Unit hit when attacking?
        /// </summary>
        /// <remarks>0 no chance, 100 sure hit</remarks>
        /// <value>0-100</value>
        int Accuracy
        {
            get;
        }

        /// <summary>
        /// How many attack-points are blocked
        /// </summary>
        /// <remarks>n has no limit</remarks>
        /// <value>0-n</value>
        int Defense
        {
            get;
        }

        /// <summary>
        /// How much damage will be dealt
        /// </summary>
        /// <remarks>No Limit for n</remarks>
        /// <value>0- n</value>
        int Attack
        {
            get;
        }

        /// <summary>
        /// Name of the Unit
        /// </summary>
        /// <value>A String</value>
        string Name
        {
            get;
        }

        /// <summary>
        /// Whats the Current Health of the Unit
        /// </summary>
        /// <remarks>n has no Limit, 0 means dead</remarks>
        /// <value>0-n</value>
        int Health_Current
        {
            get;
        }

        /// <summary>
        /// Maximu Health of Unit
        /// </summary>
        /// <remarks>n has no limit, may never be 0</remarks>
        /// <value>1-n</value>
        int Health_Max
        {
            get;
        }

        /// <summary>
        /// How many fields can a unit move
        /// </summary>
        /// <remarks>n has no limits</remarks>
        /// <value>0-n</value>
        int Move
        {
            get;
        }

        /// <summary>
        /// value of Unit in Points
        /// </summary>
        /// <remarks>
        /// May not be 0
        /// n has no Limit
        /// </remarks>
        /// <value>1-n</value>
        int Points
        {
            get;
        }

        /// <summary>
        /// Maximum Weapon Range
        /// </summary>
        /// <remarks>
        /// 1 means direct neighbour
        /// n has no limit
        /// </remarks>
        /// <value>1-n</value>
        int Range_Max
        {
            get;
        }

        /// <summary>
        /// Minimu Range to hit
        /// </summary>
        /// <remarks>
        /// 1 means direct neighbour
        /// n has no limit
        /// </remarks>
        /// <value>1-n</value>
        int Range_Min
        {
            get;
        }

        string Image
        {
            get;
        }

        List<Skill> Skills
        {
            get;
        }

        /// <summary>
        /// Moves on the Field
        /// </summary>
        /// <param name="x">Target X</param>
        /// <param name="y">Target Y</param>
        /// <param name="z">Target Z</param>
        /// <remarks>Only use MOvement</remarks>
        /// <returns>Could move or cannot move</returns>
        bool MoveTo(int x, int y, int z);

        /// <summary>
        /// Attack a Unit
        /// </summary>
        /// <remarks>
        /// Try to hit a Enemy
        ///  1. is on Range
        /// 2. Accuracy CHeck
        /// 3. Attack - Defense
        /// </remarks>
        /// <returns>Damage dealt</returns>
        int AttackUnit(Unit target);

        /// <summary>
        /// Perform a Skill on a TargetCell
        /// </summary>
        /// <remarks>
        /// Target could be the Cell, Somethings Sorrounding the Cell, The Unit on the Cell...
        /// </remarks>
        /// <param name="skill">Skill to use</param>
        /// <param name="target">Target Cell</param>
        /// <returns>Changed Value</returns>
        int performSkill(Skill skill, Cell target);
    }
}
