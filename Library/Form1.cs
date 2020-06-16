using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            Gui.FrmBooks b = new Gui.FrmBooks();
            b.Show();
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            Gui.FrmMembers m = new Gui.FrmMembers();
            m.Show();
        }

        private void BtnAudience_Click(object sender, EventArgs e)
        {
            Gui.FrmAudiences a = new Gui.FrmAudiences();
            a.Show();
        }

        private void BtnBorrowBook_Click(object sender, EventArgs e)
        {

        }

        private void BtnBooksBeingBorrowed_Click(object sender, EventArgs e)
        {
            Gui.FrmBorrowingBooks b = new Gui.FrmBorrowingBooks();
            b.Show();
        }

		private void btnAuthor_Click(object sender, EventArgs e)
		{
            Gui.FrmAuthors a = new Gui.FrmAuthors();
                a.Show();
        }

        //private void btnAuthor_Click(object sender, EventArgs e)
        //{
        //    Gui.FrmAuthors a = new Gui.FrmAuthors();
        //    a.Show();
        //}
    }
}
