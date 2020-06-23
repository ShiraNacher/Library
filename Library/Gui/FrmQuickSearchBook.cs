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
	public partial class FrmQuickSearchBook : Form
	{
		Bll.ClsAuthors a;
		Bll.ClsAuthorsTable at;
		Bll.ClsBooks b;
		Bll.ClsBooksTable bt;
		Bll.ClsBookNames bn;
		Bll.ClsBookNamesTable bnt;
		string seachBy;
		public FrmQuickSearchBook()
		{
			InitializeComponent();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (rdbBookName.Checked)
				seachBy = "BookName";
			else
				seachBy = "AuthorName";
			Gui.FrmSearchResults sr = new Gui.FrmSearchResults(seachBy, txtSearch.Text);
			sr.Show();
		}
	}
}
