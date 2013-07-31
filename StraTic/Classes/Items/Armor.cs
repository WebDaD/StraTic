using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class Armor : Item
    {
        /// <summary>
        /// Creates an Object of Type Armor, loaded from table items
        /// </summary>
        /// <param name="database">Object of type Database</param>
        /// <param name="id">id of item</param>
        public Armor(Database database, int id)
        {
            List<string> fields = new List<string>();
            fields.Add("name");
            fields.Add("mod_accuracy"); 
            fields.Add("mod_attack");
            fields.Add("mod_defense");
            fields.Add("mod_range_min");
            fields.Add("mod_range_max");
            fields.Add("mod_move");
            fields.Add("mod_health");
            fields.Add("points");

            List<Condition> cs = new List<Condition>();
            cs.Add(new Condition("id", ConditionTypes.Is, id.ToString()));
            cs.Add(new Condition("item_type", ConditionTypes.Is, "armor"));

            Dictionary<int, Dictionary<string, string>> r = database.Select("items", cs, fields);

            this.id = id;
            name = r[0]["name"];
            mod_accuracy = Convert.ToInt32(r[0]["mod_accuracy"]);
            mod_attack = Convert.ToInt32(r[0]["mod_attack"]);
            mod_defense = Convert.ToInt32(r[0]["mod_defense"]);
            mod_range_min = Convert.ToInt32(r[0]["mod_range_min"]);
            mod_range_max = Convert.ToInt32(r[0]["mod_range_max"]);
            mod_move = Convert.ToInt32(r[0]["mod_move"]);
            points = Convert.ToInt32(r[0]["points"]);
            mod_health = Convert.ToInt32(r[0]["mod_health"]);
        }

        private string name;
        private int points;
        private int id;
        private int mod_accuracy;
        private int mod_attack;
        private int mod_defense;
        private int mod_range_min;
        private int mod_range_max;
        private int mod_move;
        private int mod_health;

        /// <summary>
        /// ID of Armor
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
        }

        /// <summary>
        /// Modifier on Accuracy
        /// </summary>
        public int Mod_Accuracy
        {
            get
            {
                return mod_accuracy;
            }
        }

        /// <summary>
        /// Modifier on Attack
        /// </summary>
        public int Mod_Attack
        {
            get
            {
                return mod_attack;
            }
        }

        /// <summary>
        /// Modifier on Defense
        /// </summary>
        public int Mod_Defense
        {
            get
            {
                return mod_defense;
            }
        }

        /// <summary>
        /// Modifier on Health
        /// </summary>
        public int Mod_Health
        {
            get
            {
                return mod_health;
            }
        }

        /// <summary>
        /// Modifier on Movement
        /// </summary>
        public int Mod_Move
        {
            get
            {
                return mod_move;
            }
        }

        /// <summary>
        /// Modifier on minimum Range
        /// </summary>
        public int Mod_Range_Min
        {
            get
            {
                return mod_range_min;
            }
        }

        /// <summary>
        /// Modifier on maximum Range
        /// </summary>
        public int Mod_Range_Max
        {
            get
            {
                return mod_range_max;
            }
        }

        /// <summary>
        /// Name of Armor
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Points the Armor is worth
        /// </summary>
        public int Points
        {
            get
            {
                return points;
            }
        }
    }
}
