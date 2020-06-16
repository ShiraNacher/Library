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
	public partial class FrmConfirmDelete : Form
	{
		public FrmConfirmDelete()
		{
			InitializeComponent();
		}

		private void FrmConfirmDelete_Load(object sender, EventArgs e)
		{
			//לשמור איכשהו את המקום שממנו נשלח
			lblConfirmDelete.Text = "האם אתה בטוח שאתה רוצה למחוק את " + "" + "לצמיתות?";
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			//close form
		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			Bll.ClsAudience a = new Bll.ClsAudience();//להחליף במקום שממנו נשלח
			a.Delete();//לא עובד לי
		}
	}
}
