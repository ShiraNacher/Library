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
    public partial class FrmBook_singal : Form
    {
        string state;
        Bll.ClsBooks b;
        Bll.ClsBooksTable bt;
        public FrmBook_singal()
        {
            InitializeComponent();
            state = "add";
            this.Text = "הוספת ספר";
            bt = new Bll.ClsBooksTable();
            b = new Bll.ClsBooks();
        }
        public FrmBook_singal(Bll.ClsBooks book, string s)
        {
            InitializeComponent();
            state = s;
            b = book;
            //    Bll.Support.FillComboBox
        }
        public void FillFormField()
        {
            lblCode.Text = b.BookCode.ToString();
            txtBookName.Text = b.BookName.ToString();
            txtAuthorName.Text = b.AuthorCode.ToString();
            txtBookType.Text = b.BookTypeCode.ToString();
            txtAudience.Text = b.AudienceCode.ToString();
            txtDescription.Text = b.Description.ToString();
            txtLanguage.Text = b.Language.ToString();
            txtOriginalLanguage.Text = b.OriginalLanguage.ToString();
            //txtNumberOfPages.Text = b.
            txtStickerName.Text = b.StickerName.ToString();
            txtStickerType.Text = b.StickerType.ToString();
            txtHasSeries.Text = b.HasSeries.ToString();
            txtNumberInSeries.Text = b.NumberInSeries.ToString();
            //txtAvailability.Text = b.
            //txtPublisher.Text = b.
            //txtDatePublished.Text = b.
            txtStatus.Text = b.Status.ToString();
            //fiil the rest of the things in the book class
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (state == "add")

                {
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
                        MessageBox.Show("!!");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("error");
                    }

                }

            }
        }
        public bool check()
        {
            bool ok = true;
            try
            {
                b.BookName = txtBookName.Text;
            }
            catch (Exception ex)
            {

                errorProvider1.SetError(txtBookName, ex.Message);
                ok = false;
            }
            try
            {
                b.AuthorCode = Convert.ToInt32(txtAuthorName.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAuthorName, ex.Message);
                ok = false;
            }
            try
            {
                b.BookTypeCode = Convert.ToInt32(txtBookType.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtBookType, ex.Message);
                ok = false;
            }
            try
            {
                b.AudienceCode = Convert.ToInt32(txtAudience.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtAudience, ex.Message);
                ok = false;
            }
            try
            {
                b.Description = txtDescription.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDescription, ex.Message);
                ok = false;
            }
            try
            {
                b.Language = txtLanguage.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLanguage, ex.Message);
                ok = false;
            }
            try
            {
                b.OriginalLanguage = txtOriginalLanguage.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtOriginalLanguage, ex.Message);
                ok = false;
            }
            try
            {
                b.StickerName = txtStickerName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStickerName, ex.Message);
                ok = false;
            }
            try
            {
                b.StickerType = txtStickerType.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStickerType, ex.Message);
                ok = false;
            }
            try
            {
                b.HasSeries = Convert.ToBoolean(txtAuthorName.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtHasSeries, ex.Message);
                ok = false;
            }
            try
            {
                b.NumberInSeries = Convert.ToInt32(txtNumberInSeries.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumberInSeries, ex.Message);
                ok = false;
            }
            return ok;
        }
    }
}
