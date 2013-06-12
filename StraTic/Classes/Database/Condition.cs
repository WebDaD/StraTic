using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StraTic
{
    public struct Condition
    {
        /// <summary>
        /// Field of Table to Check
        /// </summary>
        private int field;
        /// <summary>
        /// Value to Match
        /// </summary>
        private int value;
        /// <summary>
        /// Type of Match
        /// </summary>
        private ConditionTypes type;

        public Condition(string key, ConditionTypes type, string value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Returns The Condition suitable for the Database-Type.
        /// </summary>
        /// <param name="db_type">Type of Database</param>
        /// <returns>String suitable for query</returns>
        public string toString(DB_Types db_type)
        {
            switch (db_type)
            {
                case DB_Types.MySQL:
                    switch (type)
	                {
                        case ConditionTypes.Is: return "`"+field + "`='" + value+"'";
                        case ConditionTypes.Not: return "`" + field + "`!='" + value + "'";
                        case ConditionTypes.Like: return "`" + field + "` LIKE '%" + value + "'%";
                        case ConditionTypes.Greater: return "`" + field + "`>'" + value + "'";
                        case ConditionTypes.Less: return "`" + field + "`<'" + value + "'";
                        case ConditionTypes.GreaterSame: return "`" + field + "`>='" + value + "'";
                        case ConditionTypes.LessSame: return "`" + field + "`<='" + value + "'";
                        default: return "";
	                }
                case DB_Types.MSSQL:
                    switch (type)
                    {
                        case ConditionTypes.Is: return "[" + field + "]='" + value + "'";
                        case ConditionTypes.Not: return "[" + field + "]!='" + value + "'";
                        case ConditionTypes.Like: return "[" + field + "] LIKE '%" + value + "'%";
                        case ConditionTypes.Greater: return "[" + field + "]>'" + value + "'";
                        case ConditionTypes.Less: return "[" + field + "]<'" + value + "'";
                        case ConditionTypes.GreaterSame: return "[" + field + "]>='" + value + "'";
                        case ConditionTypes.LessSame: return "[" + field + "]<='" + value + "'";
                        default: return "";
                    }
                case DB_Types.Access:
                    switch (type)
                    {
                        case ConditionTypes.Is: return "[" + field + "]='" + value + "'";
                        case ConditionTypes.Not: return "[" + field + "]!='" + value + "'";
                        case ConditionTypes.Like: return "[" + field + "] LIKE '%" + value + "'%";
                        case ConditionTypes.Greater: return "[" + field + "]>'" + value + "'";
                        case ConditionTypes.Less: return "[" + field + "]<'" + value + "'";
                        case ConditionTypes.GreaterSame: return "[" + field + "]>='" + value + "'";
                        case ConditionTypes.LessSame: return "[" + field + "]<='" + value + "'";
                        default: return "";
                    }
                case DB_Types.FileSystem:
                    switch (type)
                    {
                        case ConditionTypes.Is: return "[" + field + "]='" + value + "'";
                        case ConditionTypes.Not: return "[" + field + "]!='" + value + "'";
                        case ConditionTypes.Like: return "[" + field + "] LIKE '%" + value + "'%";
                        case ConditionTypes.Greater: return "[" + field + "]>'" + value + "'";
                        case ConditionTypes.Less: return "[" + field + "]<'" + value + "'";
                        case ConditionTypes.GreaterSame: return "[" + field + "]>='" + value + "'";
                        case ConditionTypes.LessSame: return "[" + field + "]<='" + value + "'";
                        default: return "";
                    }
                case DB_Types.XML:
                    switch (type)
                    {
                        case ConditionTypes.Is: return "[" + field + "]='" + value + "'";
                        case ConditionTypes.Not: return "[" + field + "]!='" + value + "'";
                        case ConditionTypes.Like: return "[" + field + "] LIKE '%" + value + "'%";
                        case ConditionTypes.Greater: return "[" + field + "]>'" + value + "'";
                        case ConditionTypes.Less: return "[" + field + "]<'" + value + "'";
                        case ConditionTypes.GreaterSame: return "[" + field + "]>='" + value + "'";
                        case ConditionTypes.LessSame: return "[" + field + "]<='" + value + "'";
                        default: return "";
                    }
                default:
                    return "";
            }
        }
    }
}
