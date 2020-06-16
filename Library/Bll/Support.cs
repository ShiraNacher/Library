using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Library.Bll
{
    public class Support
    {
        public static void FillComboBox(ComboBox c, DataTable dt, string Display, string value)
        {
            c.DataSource = dt;
            c.DisplayMember = Display;
            c.ValueMember = value;
        }
    }
}
