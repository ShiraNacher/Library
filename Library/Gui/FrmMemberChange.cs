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
                lblState.Text = "הוספת מנוי";
            mt = new Bll.ClsMembersTable();
            m = new Bll.ClsMembers();
        }
        public FrmMemberChange(Bll.ClsMembers member, string s)
		{
            InitializeComponent();
            state = s;
            m = member;
            if (s == "update")
                lblState.Text = "עדכון פרטי מנוי";
            else
                lblState.Text = "חידוש מנוי - וודא שכל הפרטים נכונים";
            FillFormField();
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
            txtAmountOfBooks.Text = m.AmountOfBooks.ToString();

        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Check ())
            {
                m.LastAndFirstName = txtLastName.Text + " " + txtFirstName.Text;
                if (state == "add")

                {
                    try
                    {
                        m.FirstRegistration = DateTime.Today;
                        m.BeginningOfMembership = DateTime.Today;
                        m.EndOfMembership = m.BeginningOfMembership.AddYears(1);
                        if(m.AmountOfBooks == 1)
                            m.Price = 50;
                        else
                        {
                            if (m.AmountOfBooks == 2)
                                m.Price = 65;
                            else
                            {
                                if (m.AmountOfBooks == 5)
                                    m.Price = 85;
                                else
                                {
                                    if (m.AmountOfBooks == 7)
                                        m.Price = 100;
                                    else
                                        m.Price = 130;
                                }
                            }
                        }
                        m.Add();
                        MessageBox.Show("!ההוספה בוצעה בהצלחה");
                        MessageBox.Show("המחיר למנוי הוא:" + m.Price);
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
                        MessageBox.Show("העדכון בוצע בהצלחה");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("error");
                    }

                }
                if (state == "renew")

                {
                    try
                    {
                        m.BeginningOfMembership = DateTime.Today;
                        m.EndOfMembership = m.BeginningOfMembership.AddYears(1);
                        if (m.AmountOfBooks == 1)
                            m.Price = 50;
                        else
                        {
                            if (m.AmountOfBooks == 2)
                                m.Price = 65;
                            else
                            {
                                if (m.AmountOfBooks == 5)
                                    m.Price = 85;
                                else
                                {
                                    if (m.AmountOfBooks == 7)
                                        m.Price = 100;
                                    else
                                        m.Price = 130;
                                }
                            }
                        }
                        m.Update();
                        //MessageBox.Show(m.BeginningOfMembership + " " + m.EndOfMembership);
                        MessageBox.Show("החידוש בוצע בהצלחה");
                        MessageBox.Show("המחיר למנוי הוא:" + m.Price);
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
            try
            {
                m.AmountOfBooks = Convert.ToInt32(txtAmountOfBooks.Text);
            }
            catch (Exception ex)
            {

                errorProviderMemberChange.SetError(txtAmountOfBooks, ex.Message);
                ok = false;
            }
            return ok;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
