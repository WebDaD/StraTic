using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StraTic
{
    public class CellType
    {
        private int mod_attack;
        private int mod_defense;
        private int mod_range;
        private int mod_move;
        private Bitmap image;
        private string name;

        /// <summary>
        /// Get CellType From Database
        /// </summary>
        /// <param name="type">Type of Field</param>
        /// <param name="database">Object of Database</param>
        public CellType(string type, Database database)
        {
            List<string> fields = new List<string>();
            fields.Add("name");
            fields.Add("image_id"); //type: longblob
            fields.Add("mod_attack");
            fields.Add("mod_defense");
            fields.Add("mod_range");
            fields.Add("mod_move");

            List<Condition> cs = new List<Condition>();
            cs.Add(new Condition("cell_type", ConditionTypes.Is, type));

            Dictionary<int,  Dictionary<string,string>> r = database.Select("cell_types",cs, fields);

            name = r[0]["name"];
            image = database.LoadImage(Convert.ToInt32(r[0]["image_id"]));
            mod_attack = Convert.ToInt32(r[0]["mod_attack"]);
            mod_defense = Convert.ToInt32(r[0]["mod_defense"]);
            mod_range = Convert.ToInt32(r[0]["mod_range"]);
            mod_move = Convert.ToInt32(r[0]["mod_move"]);

        }

        /// <summary>
        /// Name of CellType
        /// </summary>
        public string Name { get { return name; } }

        /// <summary>
        /// Path of image to draw on the Field
        /// </summary>
        public Bitmap Image
        {
            get
            {
                return image;
            }
        }

        /// <summary>
        /// Modulation of Attack Value if on Field
        /// </summary>
        public int Mod_Attack
        {
            get
            {
                return mod_attack;
            }
        }

        /// <summary>
        /// Modulation of Defense Value if on Field
        /// </summary>
        public int Mod_Defense
        {
            get
            {
                return mod_defense;
            }
        }

        /// <summary>
        /// Modulation of Range-MAX Value if on Field
        /// </summary>
        public int Mod_Range
        {
            get
            {
                return mod_range;
            }
        }

        /// <summary>
        /// Modulation of Move Value if on Field
        /// </summary>
        public int Mod_Move
        {
            get
            {
                return mod_move;
            }
        }
    }
}
