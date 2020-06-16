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
    public partial class FrmMemberChange : Form
    {
        string state;
        Bll.ClsMembers m;
        Bll.ClsMembersTable mt;
        public FrmMemberChange()
        {
            InitializeComponent();
            state = "add";
            this.Text = "הוספת מנוי";
            mt = new Bll.ClsMembersTable();
            m = new Bll.ClsMembers();
        }
        public void FillFormField()
        {
           // lblMemberCode.Text = m.MemberCode.ToString();
            txtIDNumber.Text = m.IDNumber.ToString();
            txtLastName.Text = m.LastName.ToString();
            txtFirstName.Text = m.FirstName.ToString();
            txtPhoneNumber.Text = m.PhoneNumber.ToString();
            txtCity.Text = m.City.ToString();
            txtStreet.Text = m.Street.ToString();
            txtAppartmentNumber.Text = m.AppartmentNumber.ToString();
            dtmDateOfBirth.Text = m.DateOfBirth.ToString();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Check ())
            {
                if (state == "add")

                {
                    try
                    {
                        m.Add();
                        MessageBox.Show("!ההוספה בוצעה בהצלחה");
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
                        m.Update();
                        MessageBox.Show("!!");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("error");
                    }

                }

            }
        }
        public bool Check()
        {
            bool ok = true;
            try
            {
                m.IDNumber = txtIDNumber.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtIDNumber, ex.Message);
                ok = false;
            }
            try
            {
                m.LastName = txtLastName.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtLastName, ex.Message);
                ok = false;
            }
            try
            {
                m.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtFirstName, ex.Message);
                ok = false;
            }
            try
            {
                m.PhoneNumber = txtPhoneNumber.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtPhoneNumber, ex.Message);
                ok = false;
            }
            try
            {
                m.City = txtCity.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtCity, ex.Message);
                ok = false;
            }
            try
            {
                m.Street = txtStreet.Text;
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtStreet, ex.Message);
                ok = false;
            }
            try
            {
                m.AppartmentNumber = Convert.ToInt32(txtAppartmentNumber.Text);
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtAppartmentNumber, ex.Message);
                ok = false;
            }
            try
            {
                m.DateOfBirth = Convert.ToDateTime(dtmDateOfBirth.Text);
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(dtmDateOfBirth, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
