using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Gui
{
    public partial class FrmAuthors : Form
    {
        string state;
        Bll.ClsAuthors a;
        Bll.ClsAuthorsTable at;
        public FrmAuthors()
        {
            InitializeComponent();
            dgvAuthors.DataSource = new Bll.ClsAuthorsTable().GetDataTable();
            ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvAuthors.Columns["AuthorCode"].HeaderText = "קוד סופר";
            dgvAuthors.Columns["AuthorLastName"].HeaderText = "שם משפחה";
            dgvAuthors.Columns["AuthorFirstName"].HeaderText = "שם פרטי";
        }

        
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            pnlAddOrUpdate.Visible = true;
            a = new Bll.ClsAuthors();
            at = new Bll.ClsAuthorsTable();
            lblCode.Text = at.GetNewKey().ToString();
            txtAuthorLastName.Text = "";
            txtAuthorFirstName.Text = "";
            state = "add";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            a = new Bll.ClsAuthors(Convert.ToInt32(dgvAuthors.SelectedRows[0].Cells["AuthorCode"].Value));
            pnlAddOrUpdate.Visible = true;
            lblCode.Text = Convert.ToString(a.AuthorCode);
            txtAuthorLastName.Text = a.AuthorLastName;
            txtAuthorFirstName.Text = a.AuthorFirstName;
            state = "update";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            a = new Bll.ClsAuthors(Convert.ToInt32(dgvAuthors.SelectedRows[0].Cells[0].Value));
            pnlAddOrUpdate.Visible = false;
            DialogResult answer = MessageBox.Show("מחיקה", "?האם אתה בטוח שהינך מעוניין למחוק סופר זה לצמיתות", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (answer == DialogResult.Yes)
			{
                try
                {
                    a.Delete();
                    MessageBox.Show("!המחיקה בוצעה בהצלחה");
                }
                catch (Exception)
                {

                    MessageBox.Show("לא ניתן למחוק סופר זה");
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (state == "add")

                {
                    try
                    {
                        a.Add();
                        MessageBox.Show("!ההוספה בוצעה בהצלחה");
                        pnlAddOrUpdate.Visible = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("!לא ניתן לבצע הוספה");
                    }

                }
                if (state == "update")

                {
                    try
                    {
                        a.Update();
                        MessageBox.Show("!העדכון בוצע בהצלחה");
                        pnlAddOrUpdate.Visible = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("!לא ניתן לבצע עדכון");
                    }

                }

            }
        }

        public bool Check()
        {
            bool ok = true;
            if (state == "add")
                a.AuthorCode = Convert.ToInt32(lblCode.Text);
            try
            {
                a.AuthorLastName = txtAuthorLastName.Text;
            }
            catch (Exception ex)
            {
                errorProviderAuthors.SetError(txtAuthorLastName, ex.Message);
                ok = false;
            }
            try
            {
                a.AuthorFirstName = txtAuthorFirstName.Text;
            }
            catch (Exception ex)
            {
                errorProviderAuthors.SetError(txtAuthorFirstName, ex.Message);
                ok = false;
            }
            return ok;
        }
    }
}
