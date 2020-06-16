namespace Library.Gui
{
    partial class FrmBookChange
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBookChange));
			this.lblCodeLable = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblBookName = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtAuthorName = new System.Windows.Forms.TextBox();
			this.lblAuthorName = new System.Windows.Forms.Label();
			this.txtBookType = new System.Windows.Forms.TextBox();
			this.lblBookType = new System.Windows.Forms.Label();
			this.lblAudience = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.lblLanguage = new System.Windows.Forms.Label();
			this.lblOriginalLanguage = new System.Windows.Forms.Label();
			this.txtStickerName = new System.Windows.Forms.TextBox();
			this.lblStickerName = new System.Windows.Forms.Label();
			this.txtStickerType = new System.Windows.Forms.TextBox();
			this.lblStickerType = new System.Windows.Forms.Label();
			this.lblNumberInSeries = new System.Windows.Forms.Label();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lblHasSeries = new System.Windows.Forms.Label();
			this.txtAudience = new System.Windows.Forms.ComboBox();
			this.txtLanguage = new System.Windows.Forms.ComboBox();
			this.txtOriginalLanguage = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.errorProviderBookChange = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtNumberInSeries = new System.Windows.Forms.NumericUpDown();
			this.chkHasSeries = new System.Windows.Forms.CheckBox();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderBookChange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumberInSeries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodeLable
			// 
			this.lblCodeLable.AutoSize = true;
			this.lblCodeLable.BackColor = System.Drawing.Color.Transparent;
			this.lblCodeLable.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblCodeLable.Location = new System.Drawing.Point(497, 138);
			this.lblCodeLable.Name = "lblCodeLable";
			this.lblCodeLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCodeLable.Size = new System.Drawing.Size(63, 19);
			this.lblCodeLable.TabIndex = 0;
			this.lblCodeLable.Text = "קוד ספר";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblCode.Location = new System.Drawing.Point(369, 138);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(51, 19);
			this.lblCode.TabIndex = 1;
			this.lblCode.Text = "label2";
			// 
			// lblBookName
			// 
			this.lblBookName.AutoSize = true;
			this.lblBookName.BackColor = System.Drawing.Color.Transparent;
			this.lblBookName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblBookName.Location = new System.Drawing.Point(497, 176);
			this.lblBookName.Name = "lblBookName";
			this.lblBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblBookName.Size = new System.Drawing.Size(64, 19);
			this.lblBookName.TabIndex = 2;
			this.lblBookName.Text = "שם ספר";
			// 
			// txtBookName
			// 
			this.txtBookName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtBookName.Location = new System.Drawing.Point(337, 173);
			this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtBookName.Size = new System.Drawing.Size(116, 27);
			this.txtBookName.TabIndex = 5;
			// 
			// txtAuthorName
			// 
			this.txtAuthorName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtAuthorName.Location = new System.Drawing.Point(337, 214);
			this.txtAuthorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAuthorName.Name = "txtAuthorName";
			this.txtAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtAuthorName.Size = new System.Drawing.Size(116, 27);
			this.txtAuthorName.TabIndex = 7;
			// 
			// lblAuthorName
			// 
			this.lblAuthorName.AutoSize = true;
			this.lblAuthorName.BackColor = System.Drawing.Color.Transparent;
			this.lblAuthorName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAuthorName.Location = new System.Drawing.Point(497, 218);
			this.lblAuthorName.Name = "lblAuthorName";
			this.lblAuthorName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAuthorName.Size = new System.Drawing.Size(67, 19);
			this.lblAuthorName.TabIndex = 6;
			this.lblAuthorName.Text = "שם סופר";
			// 
			// txtBookType
			// 
			this.txtBookType.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtBookType.Location = new System.Drawing.Point(337, 255);
			this.txtBookType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBookType.Name = "txtBookType";
			this.txtBookType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtBookType.Size = new System.Drawing.Size(116, 27);
			this.txtBookType.TabIndex = 9;
			// 
			// lblBookType
			// 
			this.lblBookType.AutoSize = true;
			this.lblBookType.BackColor = System.Drawing.Color.Transparent;
			this.lblBookType.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblBookType.Location = new System.Drawing.Point(502, 256);
			this.lblBookType.Name = "lblBookType";
			this.lblBookType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblBookType.Size = new System.Drawing.Size(62, 19);
			this.lblBookType.TabIndex = 8;
			this.lblBookType.Text = "סוג ספר";
			// 
			// lblAudience
			// 
			this.lblAudience.AutoSize = true;
			this.lblAudience.BackColor = System.Drawing.Color.Transparent;
			this.lblAudience.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAudience.Location = new System.Drawing.Point(499, 297);
			this.lblAudience.Name = "lblAudience";
			this.lblAudience.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAudience.Size = new System.Drawing.Size(62, 19);
			this.lblAudience.TabIndex = 10;
			this.lblAudience.Text = "קהל יעד";
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtDescription.Location = new System.Drawing.Point(337, 337);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtDescription.Size = new System.Drawing.Size(116, 27);
			this.txtDescription.TabIndex = 13;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.BackColor = System.Drawing.Color.Transparent;
			this.lblDescription.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblDescription.Location = new System.Drawing.Point(516, 340);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDescription.Size = new System.Drawing.Size(45, 19);
			this.lblDescription.TabIndex = 12;
			this.lblDescription.Text = "תיאור";
			// 
			// lblLanguage
			// 
			this.lblLanguage.AutoSize = true;
			this.lblLanguage.BackColor = System.Drawing.Color.Transparent;
			this.lblLanguage.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblLanguage.Location = new System.Drawing.Point(521, 382);
			this.lblLanguage.Name = "lblLanguage";
			this.lblLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLanguage.Size = new System.Drawing.Size(40, 19);
			this.lblLanguage.TabIndex = 14;
			this.lblLanguage.Text = "שפה";
			// 
			// lblOriginalLanguage
			// 
			this.lblOriginalLanguage.AutoSize = true;
			this.lblOriginalLanguage.BackColor = System.Drawing.Color.Transparent;
			this.lblOriginalLanguage.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblOriginalLanguage.Location = new System.Drawing.Point(487, 424);
			this.lblOriginalLanguage.Name = "lblOriginalLanguage";
			this.lblOriginalLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblOriginalLanguage.Size = new System.Drawing.Size(77, 19);
			this.lblOriginalLanguage.TabIndex = 16;
			this.lblOriginalLanguage.Text = "שפת מקור";
			// 
			// txtStickerName
			// 
			this.txtStickerName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtStickerName.Location = new System.Drawing.Point(35, 184);
			this.txtStickerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStickerName.Name = "txtStickerName";
			this.txtStickerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtStickerName.Size = new System.Drawing.Size(116, 27);
			this.txtStickerName.TabIndex = 21;
			// 
			// lblStickerName
			// 
			this.lblStickerName.AutoSize = true;
			this.lblStickerName.BackColor = System.Drawing.Color.Transparent;
			this.lblStickerName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblStickerName.Location = new System.Drawing.Point(189, 187);
			this.lblStickerName.Name = "lblStickerName";
			this.lblStickerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStickerName.Size = new System.Drawing.Size(83, 19);
			this.lblStickerName.TabIndex = 20;
			this.lblStickerName.Text = "שם מדבקה";
			// 
			// txtStickerType
			// 
			this.txtStickerType.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtStickerType.Location = new System.Drawing.Point(35, 226);
			this.txtStickerType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStickerType.Name = "txtStickerType";
			this.txtStickerType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtStickerType.Size = new System.Drawing.Size(116, 27);
			this.txtStickerType.TabIndex = 23;
			// 
			// lblStickerType
			// 
			this.lblStickerType.AutoSize = true;
			this.lblStickerType.BackColor = System.Drawing.Color.Transparent;
			this.lblStickerType.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblStickerType.Location = new System.Drawing.Point(192, 227);
			this.lblStickerType.Name = "lblStickerType";
			this.lblStickerType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStickerType.Size = new System.Drawing.Size(80, 19);
			this.lblStickerType.TabIndex = 22;
			this.lblStickerType.Text = "מיון מדבקה";
			// 
			// lblNumberInSeries
			// 
			this.lblNumberInSeries.AutoSize = true;
			this.lblNumberInSeries.BackColor = System.Drawing.Color.Transparent;
			this.lblNumberInSeries.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblNumberInSeries.Location = new System.Drawing.Point(173, 310);
			this.lblNumberInSeries.Name = "lblNumberInSeries";
			this.lblNumberInSeries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNumberInSeries.Size = new System.Drawing.Size(99, 19);
			this.lblNumberInSeries.TabIndex = 24;
			this.lblNumberInSeries.Text = "מספר בסדרה";
			// 
			// txtStatus
			// 
			this.txtStatus.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtStatus.Location = new System.Drawing.Point(35, 354);
			this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtStatus.Size = new System.Drawing.Size(116, 27);
			this.txtStatus.TabIndex = 33;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.BackColor = System.Drawing.Color.Transparent;
			this.lblStatus.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblStatus.Location = new System.Drawing.Point(220, 355);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStatus.Size = new System.Drawing.Size(52, 19);
			this.lblStatus.TabIndex = 32;
			this.lblStatus.Text = "סטטוס";
			// 
			// lblHasSeries
			// 
			this.lblHasSeries.AutoSize = true;
			this.lblHasSeries.BackColor = System.Drawing.Color.Transparent;
			this.lblHasSeries.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblHasSeries.Location = new System.Drawing.Point(177, 267);
			this.lblHasSeries.Name = "lblHasSeries";
			this.lblHasSeries.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblHasSeries.Size = new System.Drawing.Size(95, 19);
			this.lblHasSeries.TabIndex = 34;
			this.lblHasSeries.Text = "נמצא בסדרה";
			// 
			// txtAudience
			// 
			this.txtAudience.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtAudience.FormattingEnabled = true;
			this.txtAudience.Location = new System.Drawing.Point(337, 294);
			this.txtAudience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAudience.Name = "txtAudience";
			this.txtAudience.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtAudience.Size = new System.Drawing.Size(116, 27);
			this.txtAudience.TabIndex = 36;
			// 
			// txtLanguage
			// 
			this.txtLanguage.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtLanguage.FormattingEnabled = true;
			this.txtLanguage.Items.AddRange(new object[] {
            "אנגלית",
            "עברית"});
			this.txtLanguage.Location = new System.Drawing.Point(337, 381);
			this.txtLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLanguage.Name = "txtLanguage";
			this.txtLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtLanguage.Size = new System.Drawing.Size(116, 27);
			this.txtLanguage.TabIndex = 37;
			// 
			// txtOriginalLanguage
			// 
			this.txtOriginalLanguage.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtOriginalLanguage.FormattingEnabled = true;
			this.txtOriginalLanguage.Items.AddRange(new object[] {
            "אנגלית",
            "עברית"});
			this.txtOriginalLanguage.Location = new System.Drawing.Point(337, 424);
			this.txtOriginalLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOriginalLanguage.Name = "txtOriginalLanguage";
			this.txtOriginalLanguage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtOriginalLanguage.Size = new System.Drawing.Size(116, 27);
			this.txtOriginalLanguage.TabIndex = 38;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Arial", 12F);
			this.btnSave.Location = new System.Drawing.Point(106, 401);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 47);
			this.btnSave.TabIndex = 39;
			this.btnSave.Text = "אישור";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// errorProviderBookChange
			// 
			this.errorProviderBookChange.ContainerControl = this;
			// 
			// txtNumberInSeries
			// 
			this.txtNumberInSeries.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtNumberInSeries.Location = new System.Drawing.Point(106, 307);
			this.txtNumberInSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNumberInSeries.Name = "txtNumberInSeries";
			this.txtNumberInSeries.Size = new System.Drawing.Size(45, 27);
			this.txtNumberInSeries.TabIndex = 41;
			this.txtNumberInSeries.Visible = false;
			// 
			// chkHasSeries
			// 
			this.chkHasSeries.AutoSize = true;
			this.chkHasSeries.Font = new System.Drawing.Font("Arial", 10.2F);
			this.chkHasSeries.Location = new System.Drawing.Point(133, 270);
			this.chkHasSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkHasSeries.Name = "chkHasSeries";
			this.chkHasSeries.Size = new System.Drawing.Size(18, 17);
			this.chkHasSeries.TabIndex = 42;
			this.chkHasSeries.UseVisualStyleBackColor = true;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(37, 23);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 43;
			this.pbxLogo.TabStop = false;
			// 
			// FrmBookChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(585, 485);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.chkHasSeries);
			this.Controls.Add(this.txtNumberInSeries);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtOriginalLanguage);
			this.Controls.Add(this.txtLanguage);
			this.Controls.Add(this.txtAudience);
			this.Controls.Add(this.lblHasSeries);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.lblNumberInSeries);
			this.Controls.Add(this.txtStickerType);
			this.Controls.Add(this.lblStickerType);
			this.Controls.Add(this.txtStickerName);
			this.Controls.Add(this.lblStickerName);
			this.Controls.Add(this.lblOriginalLanguage);
			this.Controls.Add(this.lblLanguage);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.lblAudience);
			this.Controls.Add(this.txtBookType);
			this.Controls.Add(this.lblBookType);
			this.Controls.Add(this.txtAuthorName);
			this.Controls.Add(this.lblAuthorName);
			this.Controls.Add(this.txtBookName);
			this.Controls.Add(this.lblBookName);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.lblCodeLable);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmBookChange";
			this.Text = "קטלוג ספר";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderBookChange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNumberInSeries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeLable;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TextBox txtBookType;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.Label lblAudience;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblOriginalLanguage;
        private System.Windows.Forms.TextBox txtStickerName;
        private System.Windows.Forms.Label lblStickerName;
        private System.Windows.Forms.TextBox txtStickerType;
        private System.Windows.Forms.Label lblStickerType;
        private System.Windows.Forms.Label lblNumberInSeries;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHasSeries;
        private System.Windows.Forms.ComboBox txtAudience;
        private System.Windows.Forms.ComboBox txtLanguage;
        private System.Windows.Forms.ComboBox txtOriginalLanguage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProviderBookChange;
        private System.Windows.Forms.NumericUpDown txtNumberInSeries;
        private System.Windows.Forms.CheckBox chkHasSeries;
		private System.Windows.Forms.PictureBox pbxLogo;
	}
}