using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace StraTic
{
    public class DB_MySQL : Database
    {
        private MySql.Data.MySqlClient.MySqlConnection Connection;

        public DB_MySQL(string db_user, string db_password, string db_server, string db_name)
        {
            this.db_server = db_server;

            Connection = new MySql.Data.MySqlClient.MySqlConnection("");
        }
    
        public override Dictionary<int, Dictionary<string,string>> Select(string table, List<Condition> conditions, List<string> fields)
        {
            Dictionary<int, Dictionary<string, string>> v = new Dictionary<int, Dictionary<string, string>>();
            open();
            MySql.Data.MySqlClient.MySqlCommand c = new MySql.Data.MySqlClient.MySqlCommand();
            c.Connection = Connection;

            string field = "id, ";
            foreach (string f in fields)
            {
                field += f + ", ";
            }
            field = field.Substring(0, field.Length - 2);

            string cond = "1=1 AND ";
            foreach (Condition co in conditions)
            {
                cond += co.toString(Type) + " AND ";
            }
            cond = cond.Substring(0, cond.Length - 5);

            c.CommandText = "SELECT "+field+" FROM "+table+" WHERE "+cond;
            MySql.Data.MySqlClient.MySqlDataReader r = c.ExecuteReader();
            while (r.Read())
            {
                Dictionary<string, string> x = new Dictionary<string, string>();
                foreach (string f in fields)
                {
                    x.Add(f,r[f].ToString());
                }
                v.Add(Convert.ToInt32(r["id"]), x);
            }
            r.Close();
            close();
            return v;
        }

        public override int Update(string table, List<Condition> conditions, Dictionary<string, string> fields_values)
        {
            throw new NotImplementedException();
        }

        public override int Delete(string table, List<Condition> conditions)
        {
            throw new NotImplementedException();
        }

        public override int Insert(string table, Dictionary<string, string> field_values)
        {
            throw new NotImplementedException();
        }

        public override Dictionary<int, List<string>> Select(string field, List<Condition> conditions)
        {
            throw new NotImplementedException();
        }

        public override DB_Types Type
        {
            get
            {
                return type;
            }
        }

        protected override bool open()
        {
            try
            {
                if (Connection.State != System.Data.ConnectionState.Open)
                {
                    Connection.Open();
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        protected override bool close()
        {
            try
            {
                if (Connection.State == System.Data.ConnectionState.Open)
                {
                    Connection.Close();
                }
                return true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return false;
            }
        }

        public override Bitmap LoadImage(int image_id)
        {
            MySql.Data.MySqlClient.MySqlDataReader myData;
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();

            string SQL;
            byte[] rawData;
            MemoryStream ms;
            UInt32 FileSize;
            Bitmap outImage;

            SQL = "SELECT image_name, image_size, image_data FROM images WHERE id =";
            SQL += image_id.ToString();

            try
            {
                cmd.Connection = Connection;
                cmd.CommandText = SQL;

                myData = cmd.ExecuteReader();

                if (!myData.HasRows)
                    throw new Exception("There are no blobs to save");

                myData.Read();

                FileSize = myData.GetUInt32(myData.GetOrdinal("image_size"));
                rawData = new byte[FileSize];

                myData.GetBytes(myData.GetOrdinal("image_data"), 0, rawData, 0, (Int32)FileSize);


                ms = new MemoryStream(rawData);
                outImage = new Bitmap(ms);
                ms.Close();
                ms.Dispose();

                myData.Close();
                myData.Dispose();

                cmd.Dispose();

                return outImage;


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                return null;
            }
        }

        public override bool Sync()
        {
            throw new NotImplementedException();
        }
    }
}
