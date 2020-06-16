using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsBooks
    {
        private int bookCode;
        private string bookName;
        private int bookTypeCode;
        //private string availability;
        private int authorCode;
        private string description;
        //private int numberOfPages;
        private string language;
        private string originalLanguage;
        private int audienceCode;
        private bool hasSeries;
        private int numberInSeries;
        private string stickerName;
        private string stickerType;
        //private string publisher;
        //private DateTime datePublished;
        private string status;
        public int BookCode
        {
            get { return bookCode; }
            set { bookCode = value; }
        }
        public string BookName
        {
            get { return bookName; }
            set
            {
                if (value == "")
                    throw new Exception("לא הזנת שם ספר");
                bookName = value;
            }
        }
        public int BookTypeCode
        {
            get { return bookTypeCode; }
            set { bookTypeCode = value; }
        }
        //public string Availability
        //{
        //    get { return availability; }
        //    set { availability = value; }
        //}
        public int AuthorCode
        {
            get { return authorCode; }
            set
            {
                if (value.ToString () == "")
                    throw new Exception("לא הזנת שם סופר");
                authorCode = value;
            }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //public int NumberOfPages
        //{
        //    get { return numberOfPages; }
        //    set { numberOfPages = value; }
        //}
        public string Language
        {
            get { return language; }
            set
            {
                if (value == "")
                    throw new Exception("לא הזנת שפה");
                language = value;
            }
        }
        public string OriginalLanguage
        {
            get { return originalLanguage; }
            set { originalLanguage = value; }
        }
        public int AudienceCode
        {
            get { return audienceCode; }
            set
            {
                if (value.ToString() == "")
                    throw new Exception("לא הזנת קהל יעד");
                audienceCode = value;
            }
        }
        public bool HasSeries
        {
            get { return hasSeries; }
            set
            {
                if (value.ToString() == "")
                    throw new Exception("לא הוכנסו נתונים");
                hasSeries = value;
            }
        }
        public int NumberInSeries
        {
            get { return numberInSeries; }
            set { numberInSeries = value; }
        }
        public string StickerName
        {
            get { return stickerName; }
            set
            {
                if (value == "")
                    throw new Exception("לא הוכנסו נתונים");
                stickerName = value;
            }
        }
        public string StickerType
        {
            get { return stickerType; }
            set
            {
                if (value == "")
                    throw new Exception("לא הוכנסו נתונים");
                stickerType = value;
            }
        }
        //public string Publisher
        //{
        //    get { return publisher; }
        //    set { publisher = value; }
        //}
        //public DateTime DatePublished
        //{
        //    get { return datePublished; }
        //    set { datePublished = value; }
        //}
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.bookCode = Convert.ToInt32(drow["BookCode"]);
            this.bookName = drow["BookName"].ToString();
            this.bookTypeCode = Convert.ToInt32(drow["BookTypeCode"]);//?
            //this.availability = drow["Availability"].ToString();
            this.authorCode = Convert.ToInt32(drow["AuthorCode"]);
            this.description = drow["Description"].ToString();
            //this.numberOfPages = Convert.ToInt32(drow["NumberOfPages"]);
            this.language = drow["Language"].ToString();
            this.originalLanguage = drow["OriginalLanguage"].ToString();
            this.audienceCode = Convert.ToInt32(drow["AudienceCode"]);
            this.hasSeries = Convert.ToBoolean(drow["HasSeries"]);
            this.numberInSeries = Convert.ToInt32(drow["NumberInSeries"]);
            this.stickerName = drow["StickerName"].ToString();
            //this.publisher = drow["Publisher"].ToString();
            //this.datePublished = Convert.ToDateTime(drow["DatePublished"]);
            this.status = drow["Status"].ToString();
        }
        public void FillDataRow()
        {
            drow["BookCode"] = this.bookCode;
            drow["BookName"] = this.bookName;
            drow["BookTypeCode"] = this.bookTypeCode;
            //drow["Availability"] = this.availability;
            drow["AuthorCode"] = this.authorCode;
            drow["Description"] = this.description;
            //drow["NumberOfPages"] = this.numberOfPages;
            drow["Language"] = this.language;
            drow["OriginalLanguage"] = this.originalLanguage;
            drow["AudienceCode"] = this.audienceCode;
            drow["HasSeries"] = this.hasSeries;
            drow["NumberInSeries"] = this.numberInSeries;
            drow["StickerName"] = this.stickerName;
            //drow["Publisher"] = this.publisher;
            //drow["DatePublished"] = this.datePublished;
            drow["Status"] = this.status;
        }
        public ClsBooks()
        {

        }
        public ClsBooks(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsBooks(int id)
        {
            ClsBooksTable cat = new ClsBooksTable();
            drow = cat.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsBooksTable ct = new ClsBooksTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsBooksTable c = new ClsBooksTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsBooksTable c = new ClsBooksTable();
            c.Save();
        }
    }
}
