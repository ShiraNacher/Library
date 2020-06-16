using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Gui
{
    public partial class FrmBorrowingBooks : Form
    {
        Bll.ClsMembers m;
        Bll.ClsMembersTable mt;
        Bll.ClsBorrowBook b;
        Bll.ClsBorrowBookTable bt;
        Bll.ClsBooksBeingBorrowed bb;
        Bll.ClsBooksBeingBorrowedTable bbt;
        DataTable borrt;
        public FrmBorrowingBooks()
        {
            InitializeComponent();
            Bll.Support.FillComboBox(txtSearchByName,new Bll.ClsMembersTable().GetFullName (), "FullName", "IDNumber");

            m = new Bll.ClsMembers();
            mt = new Bll.ClsMembersTable();
            //משתנה מסוג טבלה המכילה את ההשאלות של המנוי
        }

        public void fillChildren()
        {
            ListViewItem item;
            for (int i = 0; i < borrt.Rows.Count; i++)
            {
                TimeSpan t = Convert.ToDateTime(borrt.Rows[i]["ReturnDate"]) - Convert.ToDateTime(borrt.Rows[i]["BorrowingDate"]);
                //DateTime .Equals()
                //int misday;
                //misday = borrt.Rows[i]["BorrowingDate"] - borrt.Rows[i]["ReturnDate"];
                item = new ListViewItem(new string[] { borrt.Rows[i]["BookCode"].ToString(), borrt.Rows[i]["BookName"].ToString(), borrt.Rows[i]["BorrowingDate"].ToString(), t.Days.ToString(), borrt.Rows[i]["ReturnDate"].ToString() });
                lsvBorrowing.Items.Add(item);
            }

        }

        //       Bll.ClsBorrowBookTable b;

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtSearchByID.Text !="")
            {
                if (mt.Find ("IDNumber", txtSearchByID.Text )!=null)
                {
                    m = new Bll.ClsMembers(txtSearchByID.Text);
                    txtReaderName.Text = m.IDNumber;
                   txtReaderID.Text = m.FirstName + " " + m.LastName;
                    txtReaderPhoneNumber.Text = m.PhoneNumber;
                    //   b = new Bll.ClsBorrowBookTable();
                    borrt = new Bll.ClsBorrowBookTable().Getborrowbook(m.IDNumber);
                    //פעולה הממלאת את הליסט בהשאלות של המשאיל, היא עוברת על הטבלה שקיבלנו בשאילתהgetbb  
                    fillChildren();
                }
               
                
            }
            //if(txtSearchByName.Text !="")
            //{
            //    if(mt.Find("LastName"+ "" + "FirstName", txtSearchByName.Text)!=null)
            //    {
            //        m = new Bll.ClsMembers(txtSearchByName.Text);
            //        txtReaderName.Text = m.IDNumber;
            //        txtReaderID.Text = m.FirstName + " " + m.LastName;
            //        txtReaderPhoneNumber.Text = m.PhoneNumber;
            //    }
            //}
        }
        
        
        private void TxtSearchByName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void btnAddBook_Click(object sender, EventArgs e)
		{
            b = new Bll.ClsBorrowBook();//?
            bt = new Bll.ClsBorrowBookTable();//?
            bb = new Bll.ClsBooksBeingBorrowed();
            bbt = new Bll.ClsBooksBeingBorrowedTable();
            try
            {
                bb.BookCode = Convert.ToInt32(txtNewBookCode.Text);
                bb.Add();
            }
            catch (Exception ex)
            {
                errorProviderBooks.SetError(txtNewBookCode, ex.Message);
            }
        }

		private void txtSearchByID_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
