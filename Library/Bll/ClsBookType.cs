using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBookType
    {
        private int bookTypeCode;
        private string bookTypeName;
        public int BookTypeCode
        {
            get { return bookTypeCode; }
            set { bookTypeCode = value; }
        }
        public string BookTypeName
        {
            get { return bookTypeName; }
            set
            {
                if (value == "")
                    throw new Exception("לא הזנת שם סוג ספר");
                bookTypeName = value;
            }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.bookTypeCode = Convert.ToInt32(drow["BookTypeCode"]);
            this.bookTypeName = drow["BookTypeName"].ToString();
        }
        public void FillDataRow()
        {
            drow["BookTypeCode"] = this.bookTypeCode;
            drow["BookTypeName"] = this.bookTypeName;
        }
        public ClsBookType()
        {

        }
        public ClsBookType(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBookType(int id)
        {
            ClsBookTypeTable cat = new ClsBookTypeTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBookTypeTable ct = new ClsBookTypeTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBookTypeTable c = new ClsBookTypeTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBookTypeTable c = new ClsBookTypeTable();
            c.Save();
        }
    }
}
