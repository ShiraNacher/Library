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
	public partial class FrmSearchResults : Form
	{
		Bll.ClsAuthors a;
		Bll.ClsAuthorsTable at;
		Bll.ClsBooks b;
		Bll.ClsBooksTable bt;
		Bll.ClsBookNames bn;
		Bll.ClsBookNamesTable bnt;
		string seachBy;
		public FrmSearchResults()
		{
			InitializeComponent();
		}
		public FrmSearchResults(string s, string name)
		{
			InitializeComponent();
			Bll.ClsBooksTable bt = new Bll.ClsBooksTable();
			DataView dvBookSearch = new DataView(bt.GetDataTable());
			if (s == "BookName")
			{
				dvBookSearch.Sort = "BookName";
				dvBookSearch.RowFilter = "BookName=" + name;
				dvBookSearch.RowFilter = "BookName like '" + name + "%'";
			}
		}
	}
}
