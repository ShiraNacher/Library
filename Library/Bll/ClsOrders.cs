using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Library.Bll
{
    public class ClsOrders
    {
        private int orderCode;
        private int memberCode;//? should I do memberName instead?
        private int bookCode;
        private DateTime dateOrdered;
        private string status;
        public int OrderCode
        {
            get { return orderCode; }
            set { orderCode = value; }
        }
        public int MembershipCode
        {
            get { return memberCode; }
            set { memberCode = value; }
        }
        public int BookCode
        {
            get { return bookCode; }
            set { bookCode = value; }
        }
        public DateTime DateOrdered
        {
            get { return dateOrdered; }
            set { dateOrdered = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        private DataRow drow;
        public void FillFields()
        {
            this.orderCode = Convert.ToInt32(drow["OrderCode"]);
            this.memberCode = Convert.ToInt32(drow["MemberCode"]);
            this.bookCode = Convert.ToInt32(drow["BookCode"]);
            this.dateOrdered = Convert.ToDateTime(drow["DateOrdered"]);
            this.status = drow["Status"].ToString();
        }
        public void FillDataRow()
        {
            drow["OrderCode"] = this.orderCode;
            drow["MemberCode"] = this.memberCode;
            drow["BookCode"] = this.bookCode;
            drow["DateOrdered"] = this.DateOrdered;
            drow["Status"] = this.status;
        }
        public ClsOrders()
        {

        }
        public ClsOrders(DataRow dr)
        {
            drow = dr;
            FillFields();
        }
        public ClsOrders(int id)
        {
            ClsOrdersTable cot = new ClsOrdersTable();
            drow = cot.Find(id);
            FillFields();
        }
        public void Add()
        {
            ClsOrdersTable ct = new ClsOrdersTable();
            drow = ct.GetNewRow();
            FillDataRow();
            ct.AddRow(drow);
        }
        public void Update()
        {
            FillDataRow();
            Bll.ClsOrdersTable c = new ClsOrdersTable();
            c.Save();
        }
        public void Delete()
        {
            drow.Delete();
            ClsOrdersTable c = new ClsOrdersTable();
            c.Save();
        }
    }
}
