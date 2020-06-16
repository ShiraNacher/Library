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
    public partial class FrmMembers : Form
    {
        Bll.ClsMembers m;
        Bll.ClsMembersTable mt;
        public FrmMembers()
        {
            InitializeComponent();
            mt = new Bll.ClsMembersTable();
            dgvMembers.DataSource = mt.GetDataTable();
            ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvMembers.Columns["LastName"].HeaderText = "שם משפחה";
            dgvMembers.Columns["FirstName"].HeaderText = "שם פרטי";
            dgvMembers.Columns["IDNumber"].HeaderText = "ת''ז";
            dgvMembers.Columns["PhoneNumber"].HeaderText = "טלפון";
            dgvMembers.Columns["City"].HeaderText = "עיר";
            dgvMembers.Columns["Street"].HeaderText = "רחוב";
            dgvMembers.Columns["AppartmentNumber"].HeaderText = "מספר בית";
            dgvMembers.Columns["DateOfBirth"].HeaderText = "תאריך לידה";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmBookChange fb = new FrmBookChange();//change to member
            fb.Show();
        }
    }
}
