using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace StraTic
{
    public class Game
    {
        private Field world;
        private List<Player> players;
        private List<WinningConditions> winningconditions;

        public Game(List<Player> players, List<WinningConditions> winnigsconditions, Field world)
        {
            database = Database.getDatabase((DB_Types)Enum.Parse(typeof(DB_Types), ConfigurationManager.AppSettings["DB_Type"]),
                        ConfigurationManager.AppSettings["DB_User"],
                        ConfigurationManager.AppSettings["DB_Password"],
                        ConfigurationManager.AppSettings["DB_Server"],
                        ConfigurationManager.AppSettings["DB_Name"]);
            world = Field.createField(new Random().Next(0, 9999),
                                    Convert.ToInt32(ConfigurationManager.AppSettings["Field_Width"]),
                                    Convert.ToInt32(ConfigurationManager.AppSettings["Field_Height"]),
                                    Convert.ToInt32(ConfigurationManager.AppSettings["Field_Depth"]));
            for (int i = 0; i < Convert.ToInt32(ConfigurationManager.AppSettings["Players"]); i++)
            {
                players.Add(new Player());
            }

        }

        public Game()
        {
            throw new System.NotImplementedException();
        }
    
        public List<Player> Players
        {
            get
            {
                return players;
            }
        }

        public Field World
        {
            get
            {
                return world;
            }
        }

        public List<WinningConditions> WinningConditions
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void Turn()
        {
            throw new System.NotImplementedException();
        }
    }
}
