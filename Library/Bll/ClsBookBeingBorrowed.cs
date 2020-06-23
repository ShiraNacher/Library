using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBookBeingBorrowed
    {
        private int bookBeingBorrowedCode;
        private int borrowingCode;
        private int bookCode;
        private string status;
        public int BookBeingBorrowedCode
        {
            get { return bookBeingBorrowedCode; }
            set { bookBeingBorrowedCode = value; }
        }
        public int BorrowingCode
        {
            get { return borrowingCode; }
            set { borrowingCode = value; }
        }
        public int BookCode
        {
            get { return bookCode; }
            set { bookCode = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.bookBeingBorrowedCode = Convert.ToInt32(drow["BookBeingBorrowedCode"]);
            this.borrowingCode = Convert.ToInt32(drow["BorrowingCode"]);
            this.bookCode = Convert.ToInt32(drow["BookCode"]);
            this.status = drow["Status"].ToString();
        }
        public void FillDataRow()
        {
            drow["BookBeingBorrowedCode"] = this.bookBeingBorrowedCode;
            drow["BorrowingCode"] = this.borrowingCode;
            drow["BookCode"] = this.bookCode;
            drow["Status"] = this.status;
        }
        public ClsBookBeingBorrowed()
        {

        }
        public ClsBookBeingBorrowed(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBookBeingBorrowed(int id)
        {
            ClsBookBeingBorrowedTable cat = new ClsBookBeingBorrowedTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBookBeingBorrowedTable ct = new ClsBookBeingBorrowedTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBookBeingBorrowedTable c = new ClsBookBeingBorrowedTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBookBeingBorrowedTable c = new ClsBookBeingBorrowedTable();
            c.Save();
        }
    }
}
