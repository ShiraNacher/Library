using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsMembers
    {
       // private int memberCode;
        private string idNumber;
        private string lastName;
        private string firstName;
        private string lastAndFirstName;
        private string phoneNumber;
        private string city;
        private string street;
        private int appartmentNumber;
        private DateTime dateOfBirth;
        private int amountOfBooks;//added
        private DateTime firstRegistration;//added
        private DateTime beginningOfMembership;//added
        private DateTime endOfMembership;//added
        private int price;//added
        //public int MemberCode
        //{
        //    get { return memberCode; }
        //    set { memberCode = value; }
        //}
        public string IDNumber
        {
            get { return idNumber; }
            set
            {
                if (value== "" || !Bll.ValidCheck.LegalId(value.ToString()))
                    throw new Exception("לא הזנת ת''ז תקין");
                idNumber = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastAndFirstName
        {
            get { return lastAndFirstName; }
            set { lastAndFirstName = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int AppartmentNumber
        {
            get { return appartmentNumber; }
            set { appartmentNumber = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        public int AmountOfBooks
        {
            get { return amountOfBooks; }
            set { amountOfBooks = value; }
        }
        public DateTime FirstRegistration
        {
            get { return firstRegistration; }
            set { firstRegistration = value; }
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
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            //this.memberCode = Convert.ToInt32(drow["MemberCode"]);
            this.idNumber = drow["IDNumber"].ToString ();
            this.lastName = drow["LastName"].ToString();
            this.firstName = drow["FirstName"].ToString();
            this.lastAndFirstName = drow["LastAndFirstName"].ToString();
            this.phoneNumber = drow["PhoneNumber"].ToString();
            this.city = drow["City"].ToString();
            this.street = drow["Street"].ToString();
            this.appartmentNumber = Convert.ToInt32(drow["AppartmentNumber"]);
            this.dateOfBirth = Convert.ToDateTime(drow["DateOfBirth"]);
            this.amountOfBooks = Convert.ToInt32(drow["AmountOfBooks"]);
            this.firstRegistration = Convert.ToDateTime(drow["FirstRegistration"]);
            this.beginningOfMembership = Convert.ToDateTime(drow["BeginningOfMembership"]);
            this.endOfMembership = Convert.ToDateTime(drow["EndOfMembership"]);
            this.price = Convert.ToInt32(drow["Price"]);
        }
        public void FillDataRow()
        {
          //  drow["MemberCode"] = this.memberCode;
            drow["IDNumber"] = this.idNumber;
            drow["LastName"] = this.lastName;
            drow["FirstName"] = this.firstName;
            drow["LastAndFirstName"] = this.lastAndFirstName;
            drow["PhoneNumber"] = this.phoneNumber;
            drow["City"] = this.city;
            drow["Street"] = this.street;
            drow["AppartmentNumber"] = this.appartmentNumber;
            drow["DateOfBirth"] = this.dateOfBirth;
            drow["AmountOfBooks"] = this.amountOfBooks;
            drow["FirstRegistration"] = this.firstRegistration;
            drow["BeginningOfMembership"] = this.beginningOfMembership;
            drow["EndOfMembership"] = this.endOfMembership;
            drow["Price"] = this.price;
        }
        public ClsMembers()
        {

        }
        public ClsMembers(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsMembers(int id)
        {
            ClsMembersTable cmt = new ClsMembersTable();
            drow = cmt.Find(id);
            FillFields();
        }
        public ClsMembers(string  id)
        {
            ClsMembersTable cmt = new ClsMembersTable();
            drow = cmt.Find(id);
            FillFields();
        }
        public ClsMembers(string id, string s)
        {
            if(s == "ID")
			{
                ClsMembersTable cmt = new ClsMembersTable();
                drow = cmt.Find(id);
                FillFields();
            }
            else
			{
                ClsMembersTable cmt = new ClsMembersTable();
                //drow = cmt.Find("LastName" + "FirstName", id);
                drow = cmt.Find("LastAndFirstName", id);
                FillFields();
            }
        }
        public void Add()
        {
            ClsMembersTable ct = new ClsMembersTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsMembersTable c = new ClsMembersTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsMembersTable c = new ClsMembersTable();
            c.Save();
        }
    }
}
