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
    public partial class FrmBooks : Form
    {
        Bll.ClsBooksTable bt;
        Bll.ClsBooks b;
        DataView dvBDetails;
        public FrmBooks()
        {
            InitializeComponent();
            b = new Bll.ClsBooks();
            bt = new Bll.ClsBooksTable();
			dgvBooks.DataSource = bt.GetDataTable();
			//dvBDetails = new DataView(bt.GetBookDetails());
			//dgvBooks.DataSource = dvBDetails;
			ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvBooks.Columns["BookCode"].HeaderText = "קוד ספר";
            dgvBooks.Columns["BookName"].HeaderText = "שם ספר";
            //dgvBooks.Columns["AuthorLastName & ' ' & AuthorFirstName"].HeaderText = "שם סופר";
            //dgvBooks.Columns["AudienceName"].HeaderText = "שם קהל יעד";
            dgvBooks.Columns["Description"].HeaderText = "תיאור";
            dgvBooks.Columns["Language"].HeaderText = "שפה";
            dgvBooks.Columns["OriginalLanguage"].HeaderText = "שפת מקור";
            dgvBooks.Columns["BookType"].HeaderText = "סוג ספר";
            //dgvBooks.Columns["NumberOfPages"].HeaderText = "מספר עמודים";
            dgvBooks.Columns["HasSeries"].HeaderText = "נמצא בסדרה";
            dgvBooks.Columns["NumberInSeries"].HeaderText = "מספר בסדרה";
            //dgvBooks.Columns["Publisher"].HeaderText = "מוציא לאור";
            //dgvBooks.Columns["DatePublished"].HeaderText = "תאריך הוצאה לאור";
            //dgvBooks.Columns["DateComputerized"].HeaderText = "תאריך קטלוג";
            dgvBooks.Columns["StickerName"].HeaderText = "שם מדבקה";
            dgvBooks.Columns["stickerType"].HeaderText = "סוג מדבקה";
            dgvBooks.Columns["Availability"].HeaderText = "זמינות";
            dgvBooks.Columns["Status"].HeaderText = "סטטוס";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmBookChange fbc = new FrmBookChange();
            fbc.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            b = new Bll.ClsBooks(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookCode"].Value));
            FrmBookChange fbc = new FrmBookChange(b,"update");
            fbc.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            b = new Bll.ClsBooks(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells[0].Value));
            DialogResult answer = MessageBox.Show("מחיקה", "?האם אתה בטוח שהינך מעוניין למחוק ספר זה לצמיתות", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    b.Delete();
                    MessageBox.Show("!המחיקה בוצעה בהצלחה");
                }
                catch (Exception)
                {

                    MessageBox.Show("לא ניתן למחוק ספר זה");
                }
            }
        }

		private void btnSearch_Click(object sender, EventArgs e)
		{
            Gui.FrmQuickSearchBook s = new Gui.FrmQuickSearchBook();
            s.Show();
        }
	}
}
