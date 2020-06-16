using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBorrowBook
    {
        private int borrowBookCode;
        private int memberCode;
        private DateTime borrowingDate;
        private DateTime returnDate;
        private int amountOfBorrowingDays;
        public int BorrowBookCode
        {
            get { return borrowBookCode; }
            set { borrowBookCode = value; }
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
            this.borrowBookCode = Convert.ToInt32(drow["BorrowBookCode"]);
            this.memberCode = Convert.ToInt32(drow["MemberCode"]);
            this.borrowingDate = Convert.ToDateTime(drow["BorrowingDate"]);
            this.returnDate = Convert.ToDateTime(drow["ReturnDate"]);
            this.amountOfBorrowingDays = Convert.ToInt32(drow["AmountOfBorrowingDays"]);
        }
        public void FillDataRow()
        {
            drow["BorrowBookCode"] = this.borrowBookCode;
            drow["MemberName"] = this.memberCode;
            drow["BorrowingDate"] = this.borrowingDate;
            drow["ReturnDate"] = this.returnDate;
            drow["AmountOfBorrowingDays"] = this.amountOfBorrowingDays;
        }
        public ClsBorrowBook()
        {

        }
        public ClsBorrowBook(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBorrowBook(int id)
        {
            ClsBorrowBookTable cat = new ClsBorrowBookTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBorrowBookTable ct = new ClsBorrowBookTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBorrowBookTable c = new ClsBorrowBookTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBorrowBookTable c = new ClsBorrowBookTable();
            c.Save();
        }
    }
}
