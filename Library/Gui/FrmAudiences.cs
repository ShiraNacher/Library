using Library.Bll;
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
    public partial class FrmAudiences : Form
    {
        string state;
        Bll.ClsAudience a;
        Bll.ClsAudienceTable at;
        public FrmAudiences()
        {
            InitializeComponent();
            dgvAudience.DataSource =new Bll.ClsAudienceTable().GetDataTable ();
            ChangeHeader();
        }

        public void ChangeHeader()
        {
            dgvAudience.Columns["AudienceCode"].HeaderText = "קוד קהל יעד";
            dgvAudience.Columns["AudienceName"].HeaderText = "שם קהל יעד";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            pnlAddOrUpdate.Visible = true;
            a = new Bll.ClsAudience();
            at = new Bll.ClsAudienceTable();
            lblCode.Text = at.GetNewKey().ToString();
            txtAudienceName.Text = "";
            state = "add";
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            a = new Bll.ClsAudience(Convert.ToInt32(dgvAudience.SelectedRows[0].Cells["AudienceCode"].Value));
            pnlAddOrUpdate.Visible = true;
            lblCode.Text = Convert.ToString(a.AudienceTypeCode);
            txtAudienceName.Text = a.AudienceType;
            state = "update";
        }

        private void DgvAudience_DoubleClick(object sender, EventArgs e)
        {
            a = new Bll.ClsAudience(Convert.ToInt32(dgvAudience.SelectedRows[0].Cells[0].Value));
            txtAudienceName.Text = a.AudienceTypeCode.ToString () ;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            a = new Bll.ClsAudience(Convert.ToInt32(dgvAudience.SelectedRows[0].Cells[0].Value));
            pnlAddOrUpdate.Visible = false;
            DialogResult answer = MessageBox.Show("מחיקה", "?האם אתה בטוח שהינך מעוניין למחוק קהל יעד זה לצמיתות", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            if (answer == DialogResult.Yes)
			{
                try
                {
                    a.Delete();
                    MessageBox.Show("!המחיקה בוצעה בהצלחה");
                }
                catch (Exception)
                {

                    MessageBox.Show("לא ניתן למחוק קהל יעד זה");
                }
            }
        }
        public bool Check()
        {
            bool ok = true;
            if(state == "add")
                a.AudienceTypeCode = Convert.ToInt32(lblCode.Text);
            try
            {
                a.AudienceType = txtAudienceName.Text;
            }
            catch (Exception ex)
            {
                errorProviderAudience.SetError(txtAudienceName, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void BtnAddSave_Click(object sender, EventArgs e)
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

                        MessageBox.Show("error");
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

                        MessageBox.Show("!לא מילית את כל הנתונים");
                    }

                }

            }
        }
    }
}
