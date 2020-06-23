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
            m = new Bll.ClsMembers();
            mt = new Bll.ClsMembersTable();
            dgvMembers.DataSource = mt.GetDataTable();
            ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvMembers.Columns["LastName"].HeaderText = "שם משפחה";
            dgvMembers.Columns["FirstName"].HeaderText = "שם פרטי";
            dgvMembers.Columns["LastAndFirstName"].Visible = false;
            dgvMembers.Columns["IDNumber"].HeaderText = "ת''ז";
            dgvMembers.Columns["PhoneNumber"].HeaderText = "טלפון";
            dgvMembers.Columns["City"].HeaderText = "עיר";
            dgvMembers.Columns["Street"].HeaderText = "רחוב";
            dgvMembers.Columns["AppartmentNumber"].HeaderText = "מספר בית";
            dgvMembers.Columns["DateOfBirth"].HeaderText = "תאריך לידה";
            dgvMembers.Columns["AmountOfBooks"].HeaderText = "כמות ספרים";
            dgvMembers.Columns["FirstRegistration"].Visible = false;
            dgvMembers.Columns["BeginningOfMembership"].HeaderText = "תחילת מנוי";
            dgvMembers.Columns["EndOfMembership"].HeaderText = "סיום מנוי";
            dgvMembers.Columns["Price"].Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmMemberChange fmc = new FrmMemberChange();
            fmc.Show();
        }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
            m = new Bll.ClsMembers(Convert.ToString(dgvMembers.SelectedRows[0].Cells["IDNumber"].Value));
            FrmMemberChange fmc = new FrmMemberChange(m, "update");
            fmc.Show();
        }

		private void btnDelete_Click(object sender, EventArgs e)
		{
            m = new Bll.ClsMembers(Convert.ToString(dgvMembers.SelectedRows[0].Cells[0].Value));
            DialogResult answer = MessageBox.Show("מחיקה", "?האם אתה בטוח שהינך מעוניין למחוק מנוי זה לצמיתות", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            if (answer == DialogResult.Yes)
            {
                try
                {
                    m.Delete();
                    MessageBox.Show("!המחיקה בוצעה בהצלחה");
                }
                catch (Exception)
                {

                    MessageBox.Show("לא ניתן למחוק מנוי זה");
                }
            }
        }

		private void btnRenewMember_Click(object sender, EventArgs e)
		{
            m = new Bll.ClsMembers(Convert.ToString(dgvMembers.SelectedRows[0].Cells["IDNumber"].Value));
            FrmMemberChange fmc = new FrmMemberChange(m, "renew");
            fmc.Show();
        }
	}
}
