using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBooksBeingBorrowed
    {
        private int booksBeingBorrowedCode;
        private int borrowingCode;
        private int bookCode;
        private string status;
        public int BooksBeingBorrowedCode
        {
            get { return booksBeingBorrowedCode; }
            set { booksBeingBorrowedCode = value; }
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
            this.booksBeingBorrowedCode = Convert.ToInt32(drow["BooksBeingBorrowedCode"]);
            this.borrowingCode = Convert.ToInt32(drow["BorrowingCode"]);
            this.bookCode = Convert.ToInt32(drow["BookCode"]);
            this.status = drow["Status"].ToString();
        }
        public void FillDataRow()
        {
            drow["BooksBeingBorrowedCode"] = this.booksBeingBorrowedCode;
            drow["BorrowingCode"] = this.borrowingCode;
            drow["BookCode"] = this.bookCode;
            drow["Status"] = this.status;
        }
        public ClsBooksBeingBorrowed()
        {

        }
        public ClsBooksBeingBorrowed(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBooksBeingBorrowed(int id)
        {
            ClsBooksBeingBorrowedTable cat = new ClsBooksBeingBorrowedTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBooksBeingBorrowedTable ct = new ClsBooksBeingBorrowedTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBooksBeingBorrowedTable c = new ClsBooksBeingBorrowedTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBooksBeingBorrowedTable c = new ClsBooksBeingBorrowedTable();
            c.Save();
        }
    }
}
