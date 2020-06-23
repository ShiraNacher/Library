using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBorrowingBooks
    {
        private int borrowingBooksCode;
        private int memberCode;
        private DateTime borrowingDate;
        private DateTime returnDate;
        private int amountOfBorrowingDays;
        public int BorrowingBooksCode
        {
            get { return borrowingBooksCode; }
            set { borrowingBooksCode = value; }
        }
        public int MemberCode
        {
            get { return memberCode; }
            set
            {
                if (value.ToString() == "")
                    throw new Exception("לא הזנת שם מנוי");
                memberCode = value;
            }
        }
        public DateTime BorrowingDate
        {
            get { return borrowingDate; }
            set { borrowingDate = value; }
        }
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public int AmountOfBorrowingDays
        {
            get { return amountOfBorrowingDays; }
            set { amountOfBorrowingDays = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.borrowingBooksCode = Convert.ToInt32(drow["BorrowingBooksCode"]);
            this.memberCode = Convert.ToInt32(drow["MemberCode"]);
            this.borrowingDate = Convert.ToDateTime(drow["BorrowingDate"]);
            this.returnDate = Convert.ToDateTime(drow["ReturnDate"]);
            this.amountOfBorrowingDays = Convert.ToInt32(drow["AmountOfBorrowingDays"]);
        }
        public void FillDataRow()
        {
            drow["BorrowingBooksCode"] = this.borrowingBooksCode;
            drow["MemberName"] = this.memberCode;
            drow["BorrowingDate"] = this.borrowingDate;
            drow["ReturnDate"] = this.returnDate;
            drow["AmountOfBorrowingDays"] = this.amountOfBorrowingDays;
        }
        public ClsBorrowingBooks()
        {

        }
        public ClsBorrowingBooks(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBorrowingBooks(int id)
        {
            ClsBorrowingBooksTable cat = new ClsBorrowingBooksTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBorrowingBooksTable ct = new ClsBorrowingBooksTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBorrowingBooksTable c = new ClsBorrowingBooksTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBorrowingBooksTable c = new ClsBorrowingBooksTable();
            c.Save();
        }
    }
}
