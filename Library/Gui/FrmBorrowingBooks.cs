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
        Bll.ClsMemberships msh;
        Bll.ClsMembershipsTable msht;
        Bll.ClsBorrowingBooks b;
        Bll.ClsBorrowingBooksTable bt;
        Bll.ClsBookBeingBorrowed bb;
        Bll.ClsBookBeingBorrowedTable bbt;
        Bll.ClsBooks bk;
        DataTable borrt;
        public FrmBorrowingBooks()
        {
            InitializeComponent();
            //Bll.Support.FillComboBox(txtSearchByName, new Bll.ClsMembersTable().GetFullName(), "FullName", "IDNumber");
            Bll.Support.FillComboBox(txtSearchByName, new Bll.ClsMembersTable().GetFullNamexxx(), "LastAndFirstName", "IDNumber");
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
				listVeiwBorrowing.Columns.Add("החזרה", 50, HorizontalAlignment.Left);
				listVeiwBorrowing.Columns.Add("קוד ספר", 80, HorizontalAlignment.Left);
				listVeiwBorrowing.Columns.Add("שם ספר", 200, HorizontalAlignment.Left);
				listVeiwBorrowing.Columns.Add("תאריך השאלה", 120, HorizontalAlignment.Left);
				listVeiwBorrowing.Columns.Add("ימי השאלה", 70, HorizontalAlignment.Left);
				listVeiwBorrowing.Columns.Add("תאריך החזרה", 120, HorizontalAlignment.Left);
				item = new ListViewItem(new string[] {borrt.Rows[i]["BookCode"].ToString(), borrt.Rows[i]["BookName"].ToString(), borrt.Rows[i]["BorrowingDate"].ToString(), t.Days.ToString(), borrt.Rows[i]["ReturnDate"].ToString()});
				listVeiwBorrowing.Items.Add(item);
				listVeiwBorrowing.CheckBoxes = true;
			}
		}

		//       Bll.ClsBorrowBookTable b;

		private void Button1_Click(object sender, EventArgs e)
		{
            string state;
            if (txtSearchByID.Text != "")
            {
                if (mt.Find("IDNumber", txtSearchByID.Text) != null)
                {
                    state = "ID";
                    m = new Bll.ClsMembers(txtSearchByID.Text, state);
                    //msh = new Bll.ClsMemberships(Convert.ToInt32(txtSearchByID.Text));
                    txtReaderName.Text = m.IDNumber;
                    txtReaderID.Text = m.FirstName + " " + m.LastName;
                    txtReaderPhoneNumber.Text = m.PhoneNumber;
                    txtAmountOfBooks.Text = m.AmountOfBooks.ToString();
                    //   b = new Bll.ClsBorrowBookTable();
                    borrt = new Bll.ClsBorrowingBooksTable().Getborrowbook(m.IDNumber);
                    //פעולה הממלאת את הליסט בהשאלות של המשאיל, היא עוברת על הטבלה שקיבלנו בשאילתה GetBorrowBook  
                    fillChildren();
                }
                else
				{

				}


            }
            else
			{
                if (txtSearchByName.Text != "")
				{
                    if (mt.Find("LastAndFirstName", txtSearchByName.Text) != null)
                    {
                        state = "name";
                        m = new Bll.ClsMembers(txtSearchByName.Text, state);
                        txtSearchByID.Text = m.IDNumber;
                        //msh = new Bll.ClsMemberships(Convert.ToInt32(txtSearchByID.Text));
                        txtReaderName.Text = m.IDNumber;
                        txtReaderID.Text = m.FirstName + " " + m.LastName;
                        txtReaderPhoneNumber.Text = m.PhoneNumber;
                        //txtAmountOfBooks.Text = msh.AmountOfBooks.ToString();
                        //   b = new Bll.ClsBorrowBookTable();
                        borrt = new Bll.ClsBorrowingBooksTable().Getborrowbook(m.IDNumber);
                        //פעולה הממלאת את הליסט בהשאלות של המשאיל, היא עוברת על הטבלה שקיבלנו בשאילתה GetBorrowBook  
                        fillChildren();
                    }
                }
                else
                    MessageBox.Show("לא הזנת ערך");
            }
        }


        private void TxtSearchByName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchByName.SelectedItem = "LastAndFirstName like '" + txtSearchByName.Text + "%'";
        }

        

        private void btnAddBook_Click(object sender, EventArgs e)
		{
            bk = new Bll.ClsBooks(Convert.ToInt32(txtNewBookCode.Text));
            //b = new Bll.ClsBorrowingBooks();//?
			//bt = new Bll.ClsBorrowingBooksTable();//?
			//bb = new Bll.ClsBookBeingBorrowed();
			//bbt = new Bll.ClsBookBeingBorrowedTable();
            if(bk.Availability == true)
			{
                ListViewItem item = new ListViewItem(new string[] { txtNewBookCode.Text, bk.BookName, Convert.ToString(b.BorrowingDate), Convert.ToString(b.AmountOfBorrowingDays), Convert.ToString(b.ReturnDate) });
                listVeiwBorrowing.Items.Add(item);
                bk.Availability = false;
            }
            else
			{
                MessageBox.Show("לא ניתן להשאיל ספר זה כי הוא כבר מושאל על ידי מישהו אחר");
                txtNewBookCode.Text = "";
			}
        }

		private void txtSearchByID_TextChanged(object sender, EventArgs e)
		{
            
        }
	}
}
