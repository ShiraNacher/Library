using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBookNames
    {
        private int bookNameCode;
        private int bookCode;
        //private bool availability;
        private int numberOfPages;
        private string publisher;
        private DateTime datePublished;
        private DateTime dateComputerized;
        public int BookNameCode
        {
            get { return bookNameCode; }
            set { bookNameCode = value; }
        }
        public int BookCode
        {
            get { return bookCode; }
            set { bookCode = value; }
        }
        //public bool Availability
        //{
        //    get { return availability; }
        //    set { availability = value; }
        //}
        public int NumberOfPages
        {
            get { return numberOfPages; }
            set
            {
                if (value <=10)
                    throw new Exception("מספר דפים לא הגיוני");
                numberOfPages = value;
            }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public DateTime DatePublished
        {
            get { return datePublished; }
            set { datePublished = value; }
        }
        public DateTime DateComputerized
        {
            get { return dateComputerized; }
            set { dateComputerized = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.bookNameCode = Convert.ToInt32(drow["BookNameCode"]);
            this.bookCode = Convert.ToInt32(drow["BookCode"]);
            //this.availability = Convert.ToBolean(drow["Availability"]);
            this.numberOfPages = Convert.ToInt32(drow["NumberOfPages"]);
            this.publisher = drow["Publisher"].ToString();
            this.datePublished = Convert.ToDateTime(drow["DatePublished"]);
            this.dateComputerized = Convert.ToDateTime(drow["DateComputerized"]);
        }
        public void FillDataRow()
        {
            drow["BookNameCode"] = this.bookNameCode;
            drow["BookCode"] = this.bookCode;
            //drow["Availability"] = this.availability;
            drow["NumberOfPages"] = this.numberOfPages;
            drow["Publisher"] = this.publisher;
            drow["DatePublished"] = this.datePublished;
            drow["DateComputerized"] = this.dateComputerized;
        }
        public ClsBookNames()
        {

        }
        public ClsBookNames(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBookNames(int id)
        {
            ClsBookNamesTable cat = new ClsBookNamesTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBookNamesTable ct = new ClsBookNamesTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBookNamesTable c = new ClsBookNamesTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBookNamesTable c = new ClsBookNamesTable();
            c.Save();
        }
    }
}
