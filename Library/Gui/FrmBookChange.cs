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
    public partial class FrmBookChange : Form
    {
        string state;
        Bll.ClsBooks b;
        Bll.ClsBooksTable bt;
        Bll.ClsBookNames bn;
        public FrmBookChange()
        {
            InitializeComponent();
            state = "add";
            this.Text = "הוספת ספר";
            bt = new Bll.ClsBooksTable();
            b = new Bll.ClsBooks();
            Bll.Support.FillComboBox(txtAudience, new Bll.ClsAudienceTable().GetDataTable(), "AudienceName", "AudienceCode");
        }
        public FrmBookChange(Bll.ClsBooks book, string s)
        {
            InitializeComponent();
            state = s;
            b = book;
            Bll.Support.FillComboBox(txtAudience, new Bll.ClsAudienceTable().GetDataTable(), "AudienceName", "AudienceCode");
            FillFormFields();
        }
        public void FillFormFields()
        {
            lblCode.Text = b.BookCode.ToString();
            txtBookName.Text = b.BookName.ToString();
            txtAuthorName.Text = b.AuthorCode.ToString();
            txtBookType.Text = b.BookType.ToString();
            txtAudience.Text = b.AudienceCode.ToString();
            txtDescription.Text = b.Description.ToString();
            txtLanguage.Text = b.Language.ToString();
            txtOriginalLanguage.Text = b.OriginalLanguage.ToString();
            //?//txtNumberOfPages.Text = bn.NumberOfPages.ToString();
            txtStickerName.Text = b.StickerName.ToString();
            //?//txtStickerType.Text = b.StickerType.ToString();
            chkHasSeries.Checked = b.HasSeries;
            txtNumberInSeries.Text = b.NumberInSeries.ToString();
            //txtAvailability.Text = b.
            //?//txtPublisher.Text = bn.Publisher.ToString();
            //?//txtDateComputerized.Text = bn.DateComputerized.ToString();
            txtStatus.Text = b.Status.ToString();
            //fiil the rest of the things in the book class
        }
        public bool Check()
        {
            bool ok = true;
            try
            {
                b.BookName = txtBookName.Text;
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtBookName, ex.Message);
                ok = false;
            }
            try
            {
                b.AuthorCode = Convert.ToInt32(txtAuthorName.Text);
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtAuthorName, ex.Message);
                ok = false;
            }
            //try
            //{
            //    b.BookTypeCode = Convert.ToInt32(txtBookType.Text);
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtBookType, ex.Message);
            //    ok = false;
            //}
            try
            {
                b.AudienceCode = Convert.ToInt32(txtAudience.Text);
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtAudience, ex.Message);
                ok = false;
            }
            //try
            //{
            //    b.Description = txtDescription.Text;
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtDescription, ex.Message);
            //    ok = false;
            //}
            try
            {
                b.Language = txtLanguage.Text;
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtLanguage, ex.Message);
                ok = false;
            }
            //try
            //{
            //    b.OriginalLanguage = txtOriginalLanguage.Text;
            //}
            //catch (Exception ex)
            //{
            //    errorProvider1.SetError(txtOriginalLanguage, ex.Message);
            //    ok = false;
            //}
            try
            {
                b.StickerName = txtStickerName.Text;
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtStickerName, ex.Message);
                ok = false;
            }
            try
            {
                b.StickerType = txtStickerType.Text;
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtStickerType, ex.Message);
                ok = false;
            }
            try
            {
                b.HasSeries = Convert.ToBoolean(chkHasSeries.Checked);
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(chkHasSeries, ex.Message);
                ok = false;
            }
            try
            {
                b.NumberInSeries = Convert.ToInt32(txtNumberInSeries.Text);
            }
            catch (Exception ex)
            {
                errorProviderBookChange.SetError(txtNumberInSeries, ex.Message);
                ok = false;
            }
            return ok;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (state == "add")

                {
                    b.Availability = true;
                    try
                    {
                        b.Add();
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
                        b.Update();
                        MessageBox.Show("!העדכון בוצע בהצלחה");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("error");
                    }

                }

            }


        }

		private void chkHasSeries_CheckedChanged(object sender, EventArgs e)
		{
            if(chkHasSeries.Checked)
			{
                lblNumberInSeries.Visible = true;
                txtNumberInSeries.Visible = true;
            }
            else
			{
                lblNumberInSeries.Visible = false;
                txtNumberInSeries.Visible = false;
            }
		}
	}
}