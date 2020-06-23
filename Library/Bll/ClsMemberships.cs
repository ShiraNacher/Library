using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsMemberships
    {
        private int membershipCode;
        private int memberID;//take from memberCode
        private DateTime beginningOfMembership;
        private DateTime endOfMembership;
        private int amountOfBooks;
        private int price;
        public int MembershipCode
        {
            get { return membershipCode; }
            set { membershipCode = value; }
        }
        public int MemberID
        {
            get { return memberID; }
            set
            {
                if (value.ToString() == "")
                    throw new Exception("לא הזנת שם מנוי");
                memberID = value;
            }
        }
        public DateTime BeginningOfMembership
        {
            get { return beginningOfMembership; }
            set { beginningOfMembership = value; }
        }
        public DateTime EndOfMembership
        {
            get { return endOfMembership; }
            set { endOfMembership = value; }
        }
        public int AmountOfBooks
        {
            get { return amountOfBooks; }
            set { amountOfBooks = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.membershipCode = Convert.ToInt32(drow["MembershipCode"]);
            this.memberID = Convert.ToInt32(drow["MemberID"]);
            this.beginningOfMembership = Convert.ToDateTime(drow["BeginningOfMembership"]);
            this.endOfMembership = Convert.ToDateTime(drow["EndOfMembership"]);
            this.amountOfBooks = Convert.ToInt32(drow["AmountOfBooks"]);
            this.price = Convert.ToInt32(drow["Price"]);
        }
        public void FillDataRow()
        {
            drow["MembershipCode"] = this.membershipCode;
            drow["MemberID"] = this.memberID;
            drow["BeginningOfMembership"] = this.beginningOfMembership;
            drow["EndOfMembership"] = this.endOfMembership;
            drow["AmountOfBooks"] = this.amountOfBooks;
            drow["Price"] = this.price;
        }
        public ClsMemberships()
        {

        }
        public ClsMemberships(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsMemberships(int id)
        {
            ClsMembershipsTable cmt = new ClsMembershipsTable();
            drow = cmt.Find(id);
            FillFields();
        }
		//public ClsMemberships(string idNumber)
		//{
        //    ClsMembershipsTable cmt = new ClsMembershipsTable();
        //    drow = cmt.Find(idNumber);
        //    FillFields();
        //}
        public void Add()
        {
            ClsMembershipsTable ct = new ClsMembershipsTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsMembershipsTable c = new ClsMembershipsTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsMembershipsTable c = new ClsMembershipsTable();
            c.Save();
        }
    }
}
