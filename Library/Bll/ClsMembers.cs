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
        private string phoneNumber;
        private string city;
        private string street;
        private int appartmentNumber;
        private DateTime dateOfBirth;
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
                    throw new Exception("לא הזנת סוג זמינות");
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
        private DataRow drow;
        public void FillFields()
        {
            //this.memberCode = Convert.ToInt32(drow["MemberCode"]);
            this.idNumber =drow["IDNumber"].ToString ();
            this.lastName = drow["lastName"].ToString();
            this.firstName = drow["firstName"].ToString();
            this.phoneNumber = drow["PhoneNumber"].ToString();
            this.city = drow["City"].ToString();
            this.street = drow["Street"].ToString();
            this.appartmentNumber = Convert.ToInt32(drow["AppartmentNumber"]);
            this.dateOfBirth = Convert.ToDateTime(drow["DateOfBirth"]);
        }
        public void FillDataRow()
        {
          //  drow["MemberCode"] = this.memberCode;
            drow["IDNumber"] = this.idNumber;
            drow["LastName"] = this.lastName;
            drow["FirstName"] = this.firstName;
            drow["PhoneNumber"] = this.phoneNumber;
            drow["City"] = this.city;
            drow["Street"] = this.street;
            drow["AppartmentNumber"] = this.appartmentNumber;
            drow["DateOfBirth"] = this.dateOfBirth;
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
            ClsMembersTable cat = new ClsMembersTable();
            drow = cat.Find(id);
            FillFields();
        }
        public ClsMembers(string  id)
        {
            ClsMembersTable cat = new ClsMembersTable();
            drow = cat.Find(id);
            FillFields();
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
