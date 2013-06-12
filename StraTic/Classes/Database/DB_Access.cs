using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public class DB_Access : Database
    {
        private System.Data.OleDb.OleDbConnection Connection;

        public DB_Access()
        {
            throw new System.NotImplementedException();
        }
    
        public override Dictionary<int, List<string>> Select(string table, List<Condition> conditions, List<string> fields)
        {
            throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
        }

        protected override bool open()
        {
            throw new NotImplementedException();
        }

        protected override bool close()
        {
            throw new NotImplementedException();
        }

        public override System.Drawing.Bitmap LoadImage(int image_id)
        {
            throw new NotImplementedException();
        }

        public override bool Sync()
        {
            throw new NotImplementedException();
        }
    }
}
