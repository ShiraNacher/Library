namespace Library.Gui
{
	partial class FrmQuickSearchBook
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuickSearchBook));
			this.btnSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.rdbBookName = new System.Windows.Forms.RadioButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.rdbAuthorName = new System.Windows.Forms.RadioButton();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(185, 321);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(113, 53);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "חיפוש";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(412, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// rdbBookName
			// 
			this.rdbBookName.AutoSize = true;
			this.rdbBookName.BackColor = System.Drawing.Color.Transparent;
			this.rdbBookName.Location = new System.Drawing.Point(595, 273);
			this.rdbBookName.Name = "rdbBookName";
			this.rdbBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbBookName.Size = new System.Drawing.Size(155, 23);
			this.rdbBookName.TabIndex = 2;
			this.rdbBookName.TabStop = true;
			this.rdbBookName.Text = "חיפוש לפי שם סופר";
			this.rdbBookName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rdbBookName.UseVisualStyleBackColor = false;
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(322, 335);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(428, 27);
			this.txtSearch.TabIndex = 3;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// rdbAuthorName
			// 
			this.rdbAuthorName.AutoSize = true;
			this.rdbAuthorName.BackColor = System.Drawing.Color.Transparent;
			this.rdbAuthorName.Location = new System.Drawing.Point(598, 235);
			this.rdbAuthorName.Name = "rdbAuthorName";
			this.rdbAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdbAuthorName.Size = new System.Drawing.Size(152, 23);
			this.rdbAuthorName.TabIndex = 4;
			this.rdbAuthorName.TabStop = true;
			this.rdbAuthorName.Text = "חיפוש לפי שם ספר";
			this.rdbAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.rdbAuthorName.UseVisualStyleBackColor = false;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(33, 29);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 12;
			this.pbxLogo.TabStop = false;
			// 
			// FrmQuickSearchBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_41;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(900, 534);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.rdbAuthorName);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.rdbBookName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearch);
			this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmQuickSearchBook";
			this.Text = "FrmQuickSearch";
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rdbBookName;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.RadioButton rdbAuthorName;
		private System.Windows.Forms.PictureBox pbxLogo;
	}
}