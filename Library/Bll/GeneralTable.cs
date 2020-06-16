using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Library.Dal;
namespace Library .Bll
{
    public abstract class GeneralTable
    {
        protected static Dal.ClsDal ooo = new Dal.ClsDal();
        protected DataTable table;
        protected string key;
        private int currentRow;
        protected string TableName;
        public GeneralTable(String tableName, String key)
        {
            Dal.ClsDal.AddTable(tableName, key);
            this.table = Dal.ClsDal.GetTable(tableName);
            this.TableName = tableName;
            this.key = key;
        }
        public DataTable GetDataTable()
        {
            return this.table;
        }
        public String GetPrimaryKey()
        {
            return this.key;
        }
        public bool IsEmpty()
        {
            if (table.Rows.Count == 0)
                return true;
            return false;
        }
        public DataRow Find(String fieldName, Object value)
        {
            foreach(DataRow row in table.Rows)
            {
                if (row[fieldName].Equals(value))
                    return row;
            }
            return null;
        }
        public DataRow Find(Object value)
        {
            return Find(this.key, value);
        }
        public void Save()
        {
            try
            {
                Dal.ClsDal.Update(table.TableName);
            }
            catch(Exception)
            { }
        }
        public DataRow GetNewRow()
        {
            return table.NewRow();
        }
        public void AddRow(DataRow dr)
        {
            table.Rows.Add(dr);
            Save();
        }
        public int GetNewKey()
        {
            return Convert.ToInt32(table.Rows[table.Rows.Count - 1][key]) + 1;
        }
    }
}
