using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
//טיפול אקסס
using System.Data.OleDb;

namespace Library .Dal
{
  public  class ClsDal
    {
        private static OleDbConnection con;
        private static DataSet ds;
        public ClsDal()
        {
            string path = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = "+Application.StartupPath+ "\\Library.mdb";
            con = new OleDbConnection(path);
            ds = new DataSet();
        }
        public static void AddTable(string tableName, string keyname)
        {
            if(!ds.Tables.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName + " order by " + keyname, con);
                adapter.Fill(ds, tableName);
            }
        }
        public static DataTable GetTable(string tableName)
        {
            if (ds.Tables.Contains(tableName))
                return ds.Tables[tableName];
            else
                return null;
        }
        public static DataTable GetDisplayTable(string sqlstring)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlstring, con);
            adapter.Fill(dt);
            return dt;
        }
        public static void Update(string tableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = builder.GetInsertCommand();
            adapter.UpdateCommand = builder.GetUpdateCommand();
            adapter.DeleteCommand = builder.GetDeleteCommand();
            adapter.Update(ds, tableName);
        }
        public static Object ExecuteScalarQuery(string sqlStr)
        {
            OleDbCommand command = con.CreateCommand();
            command.CommandText = sqlStr;
            con.Open();
            Object obj = command.ExecuteScalar();
            con.Close();
            return obj;
        }
    }
}