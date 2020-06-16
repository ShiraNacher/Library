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
    public partial class FrmBook : Form
    {
        string state;
        Bll.ClsBooks b;
        Bll.ClsBooksTable bt;
        public FrmBook()
        {
            InitializeComponent();
            state = "add";
            this.Text = "הוספת ספר";
            bt = new Bll.ClsBooksTable();
            b = new Bll.ClsBooks();
        }
        public FrmBook(Bll.ClsBooks b, string state)
        {

        }
    }
}
