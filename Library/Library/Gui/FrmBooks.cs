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
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmBook fb = new FrmBook();
            fb.Show();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            b = new Bll.ClsBooks(Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookCode"].Value));
            FrmBook fb = new FrmBook(b,"update");
            fb.Show();
        }
    }
}
