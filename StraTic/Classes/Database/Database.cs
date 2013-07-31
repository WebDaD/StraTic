using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StraTic
{
    public abstract class Database
    {
        protected string db_server;
        protected string db_user;
        protected string db_password;
        protected string db_name;
        protected DB_Types type;

        /// <summary>
        /// The Type of the Database
        /// </summary>
        public DB_Types Type
        {
            get { return type; }
        }

        /// <summary>
        /// Gets Data from the Database
        /// </summary>
        /// <param name="table">Table to Get Data From</param>
        /// <param name="conditions">List of Conditions</param>
        /// <param name="fields">Fields to read data from</param>
        /// <returns>A Dictionary consisting of id and Dictionary of value and value</returns>
        public abstract Dictionary<int, Dictionary<string, string>> Select(string table, List<Condition> conditions, List<string> fields);

        /// <summary>
        /// Updates some Lines in the Database
        /// </summary>
        /// <param name="table">Table to Update Data in.</param>
        /// <param name="conditions">List of Conditions</param>
        /// <param name="fields_values">Fields and Values</param>
        /// <returns>Number of affected Rows</returns>
        public abstract int Update(string table, List<Condition> conditions, Dictionary<string, string> fields_values);

        /// <summary>
        /// Deletes Something in the Database
        /// </summary>
        /// <param name="table">Table to Delete Data from</param>
        /// <param name="conditions">List of Conditions</param>
        /// <returns>Number of affected Rows</returns>
        public abstract int Delete(string table, List<Condition> conditions);

        /// <summary>
        /// Inserts Data into the Database
        /// </summary>
        /// <param name="table">Table to insert data into</param>
        /// <param name="field_values">Fields and Values</param>
        /// <returns>Number of inserted Lines (should be 1)</returns>
        public abstract int Insert(string table, Dictionary<string, string> field_values);

        /// <summary>
        /// Creates a Database-Sub-Class and Returns it or NULL
        /// </summary>
        /// <returns>DB_MySQL or DB_MSSQL or DB_Access or DB_XML or DB_FileSyste or NULL</returns>
        public static Database getDatabase(DB_Types type, string db_user, string db_password, string db_server, string db_name)
        {
            
            switch (type)
            {
                case DB_Types.MySQL:
                    return new DB_MySQL(db_user,db_password,db_server,db_name);
                case DB_Types.MSSQL:
                    break;
                case DB_Types.Access:
                    break;
                case DB_Types.FileSystem:
                    break;
                case DB_Types.XML:
                    break;
                default:
                    break;
            }
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets a Bitmap from the "images" table.
        /// </summary>
        /// <param name="image_id">id of the image to get</param>
        /// <returns>A Object of Type Bitmap from the Database</returns>
        public abstract Bitmap LoadImage(int image_id);

        /// <summary>
        /// Gets Data From a Table
        /// </summary>
        /// <param name="table">Table to get Data</param>
        /// <param name="value">Fieldname</param>
        /// <param name="conditions">List of Confitions</param>
        /// <returns>A Dictionary consisting of id and Dictionary of value and value</returns>
        public abstract System.Collections.Generic.Dictionary<int, Dictionary<string, string>> Select(string table, string field, List<Condition> conditions);

        /// <summary>
        /// Opens the Connection
        /// </summary>
        /// <returns>Works or Not</returns>
        protected abstract bool open();

        /// <summary>
        /// Closes the Connection
        /// </summary>
        /// <returns>Worked or Not</returns>
        protected abstract bool close();

        /// <summary>
        /// Syncs the local database with the Online-Database
        /// </summary>
        /// <returns>Worked or Not</returns>
        public abstract bool Sync();
    }
}
