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
        public FrmBooks()
        {
            InitializeComponent();
            bt = new Bll.ClsBooksTable();
            dgvBooks.DataSource = bt.GetDataTable();
            ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvBooks.Columns["BookCode"].HeaderText = "קוד ספר";
            dgvBooks.Columns["BookName"].HeaderText = "שם ספר";
            dgvBooks.Columns["BookTypeCode"].HeaderText = "קוד סוג ספר";
            dgvBooks.Columns["AuthorCode"].HeaderText = "שם סופר";
            dgvBooks.Columns["Description"].HeaderText = "תיאור";
            dgvBooks.Columns["Language"].HeaderText = "שפה";
            dgvBooks.Columns["OriginalLanguage"].HeaderText = "שפת מקור";
            dgvBooks.Columns["AudienceCode"].HeaderText = "שם קהל יעד";
            dgvBooks.Columns["HasSeries"].HeaderText = "נמצא בסדרה";
            dgvBooks.Columns["NumberInSeries"].HeaderText = "מספר בסדרה";
            dgvBooks.Columns["StickerName"].HeaderText = "שם מדבקה";
            dgvBooks.Columns["stickerType"].HeaderText = "סוג מדבקה";
            dgvBooks.Columns["Status"].HeaderText = "סטטוס";
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmBookChange fb = new FrmBookChange();
            fb.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            b = new Bll.ClsBooks(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookCode"].Value));
            FrmBookChange fb = new FrmBookChange(b,"update");
            fb.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            dgvBooks.ReadOnly = false;
            btnSave.Visible = true;
        }
    }
}
