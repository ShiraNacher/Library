namespace Library.Gui
{
    partial class FrmMemberChange
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMemberChange));
			this.btnSave = new System.Windows.Forms.Button();
			this.txtCity = new System.Windows.Forms.ComboBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtAppartmentNumber = new System.Windows.Forms.TextBox();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.lblAppartmentNumber = new System.Windows.Forms.Label();
			this.lblStreet = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			this.txtIDNumber = new System.Windows.Forms.TextBox();
			this.lblIDNumber = new System.Windows.Forms.Label();
			this.dtmDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.errorProviderMemberChange = new System.Windows.Forms.ErrorProvider(this.components);
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			this.txtAmountOfBooks = new System.Windows.Forms.ComboBox();
			this.lblAmountOfBooks = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.txtPhoneNumber = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberChange)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(119, 570);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(119, 54);
			this.btnSave.TabIndex = 67;
			this.btnSave.Text = "אישור";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// txtCity
			// 
			this.txtCity.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtCity.FormattingEnabled = true;
			this.txtCity.Items.AddRange(new object[] {
            "בית שמש"});
			this.txtCity.Location = new System.Drawing.Point(62, 340);
			this.txtCity.Name = "txtCity";
			this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtCity.Size = new System.Drawing.Size(116, 27);
			this.txtCity.TabIndex = 65;
			// 
			// txtStreet
			// 
			this.txtStreet.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtStreet.Location = new System.Drawing.Point(62, 388);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtStreet.Size = new System.Drawing.Size(116, 27);
			this.txtStreet.TabIndex = 62;
			// 
			// txtAppartmentNumber
			// 
			this.txtAppartmentNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtAppartmentNumber.Location = new System.Drawing.Point(62, 431);
			this.txtAppartmentNumber.Name = "txtAppartmentNumber";
			this.txtAppartmentNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtAppartmentNumber.Size = new System.Drawing.Size(116, 27);
			this.txtAppartmentNumber.TabIndex = 59;
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.BackColor = System.Drawing.Color.Transparent;
			this.lblDateOfBirth.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblDateOfBirth.Location = new System.Drawing.Point(217, 480);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDateOfBirth.Size = new System.Drawing.Size(86, 19);
			this.lblDateOfBirth.TabIndex = 56;
			this.lblDateOfBirth.Text = "תאריך לידה";
			// 
			// lblAppartmentNumber
			// 
			this.lblAppartmentNumber.AutoSize = true;
			this.lblAppartmentNumber.BackColor = System.Drawing.Color.Transparent;
			this.lblAppartmentNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAppartmentNumber.Location = new System.Drawing.Point(225, 434);
			this.lblAppartmentNumber.Name = "lblAppartmentNumber";
			this.lblAppartmentNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAppartmentNumber.Size = new System.Drawing.Size(75, 19);
			this.lblAppartmentNumber.TabIndex = 55;
			this.lblAppartmentNumber.Text = "מספר בית";
			// 
			// lblStreet
			// 
			this.lblStreet.AutoSize = true;
			this.lblStreet.BackColor = System.Drawing.Color.Transparent;
			this.lblStreet.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblStreet.Location = new System.Drawing.Point(264, 391);
			this.lblStreet.Name = "lblStreet";
			this.lblStreet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblStreet.Size = new System.Drawing.Size(40, 19);
			this.lblStreet.TabIndex = 54;
			this.lblStreet.Text = "רחוב";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.BackColor = System.Drawing.Color.Transparent;
			this.lblCity.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblCity.Location = new System.Drawing.Point(270, 345);
			this.lblCity.Name = "lblCity";
			this.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCity.Size = new System.Drawing.Size(30, 19);
			this.lblCity.TabIndex = 52;
			this.lblCity.Text = "עיר";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
			this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblPhoneNumber.Location = new System.Drawing.Point(258, 303);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPhoneNumber.Size = new System.Drawing.Size(42, 19);
			this.lblPhoneNumber.TabIndex = 51;
			this.lblPhoneNumber.Text = "טלפון";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtFirstName.Location = new System.Drawing.Point(62, 257);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtFirstName.Size = new System.Drawing.Size(116, 27);
			this.txtFirstName.TabIndex = 50;
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
			this.lblFirstName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblFirstName.Location = new System.Drawing.Point(237, 260);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblFirstName.Size = new System.Drawing.Size(67, 19);
			this.lblFirstName.TabIndex = 49;
			this.lblFirstName.Text = "שם פרטי";
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtLastName.Location = new System.Drawing.Point(62, 217);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtLastName.Size = new System.Drawing.Size(116, 27);
			this.txtLastName.TabIndex = 48;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.BackColor = System.Drawing.Color.Transparent;
			this.lblLastName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblLastName.Location = new System.Drawing.Point(217, 220);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLastName.Size = new System.Drawing.Size(87, 19);
			this.lblLastName.TabIndex = 47;
			this.lblLastName.Text = "שם משפחה";
			// 
			// txtIDNumber
			// 
			this.txtIDNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtIDNumber.Location = new System.Drawing.Point(62, 176);
			this.txtIDNumber.Name = "txtIDNumber";
			this.txtIDNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtIDNumber.Size = new System.Drawing.Size(116, 27);
			this.txtIDNumber.TabIndex = 46;
			// 
			// lblIDNumber
			// 
			this.lblIDNumber.AutoSize = true;
			this.lblIDNumber.BackColor = System.Drawing.Color.Transparent;
			this.lblIDNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblIDNumber.Location = new System.Drawing.Point(267, 181);
			this.lblIDNumber.Name = "lblIDNumber";
			this.lblIDNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblIDNumber.Size = new System.Drawing.Size(33, 19);
			this.lblIDNumber.TabIndex = 45;
			this.lblIDNumber.Text = "ת\"ז";
			// 
			// dtmDateOfBirth
			// 
			this.dtmDateOfBirth.Font = new System.Drawing.Font("Arial", 10.2F);
			this.dtmDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtmDateOfBirth.Location = new System.Drawing.Point(62, 477);
			this.dtmDateOfBirth.Name = "dtmDateOfBirth";
			this.dtmDateOfBirth.Size = new System.Drawing.Size(116, 27);
			this.dtmDateOfBirth.TabIndex = 68;
			this.dtmDateOfBirth.Value = new System.DateTime(2020, 6, 15, 16, 50, 1, 0);
			this.dtmDateOfBirth.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
			// 
			// errorProviderMemberChange
			// 
			this.errorProviderMemberChange.ContainerControl = this;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(28, 25);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 69;
			this.pbxLogo.TabStop = false;
			// 
			// txtAmountOfBooks
			// 
			this.txtAmountOfBooks.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtAmountOfBooks.FormattingEnabled = true;
			this.txtAmountOfBooks.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "7",
            "10"});
			this.txtAmountOfBooks.Location = new System.Drawing.Point(62, 523);
			this.txtAmountOfBooks.Name = "txtAmountOfBooks";
			this.txtAmountOfBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtAmountOfBooks.Size = new System.Drawing.Size(116, 27);
			this.txtAmountOfBooks.TabIndex = 71;
			// 
			// lblAmountOfBooks
			// 
			this.lblAmountOfBooks.AutoSize = true;
			this.lblAmountOfBooks.BackColor = System.Drawing.Color.Transparent;
			this.lblAmountOfBooks.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAmountOfBooks.Location = new System.Drawing.Point(217, 526);
			this.lblAmountOfBooks.Name = "lblAmountOfBooks";
			this.lblAmountOfBooks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblAmountOfBooks.Size = new System.Drawing.Size(87, 19);
			this.lblAmountOfBooks.TabIndex = 70;
			this.lblAmountOfBooks.Text = "כמות ספרים";
			// 
			// lblState
			// 
			this.lblState.BackColor = System.Drawing.Color.Transparent;
			this.lblState.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
			this.lblState.Location = new System.Drawing.Point(185, 25);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(156, 119);
			this.lblState.TabIndex = 72;
			this.lblState.Text = "lblState";
			this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtPhoneNumber.Location = new System.Drawing.Point(62, 300);
			this.txtPhoneNumber.Mask = "999-000-0000";
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(116, 27);
			this.txtPhoneNumber.TabIndex = 73;
			// 
			// FrmMemberChange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(367, 647);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.txtAmountOfBooks);
			this.Controls.Add(this.lblAmountOfBooks);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.dtmDateOfBirth);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.txtStreet);
			this.Controls.Add(this.txtAppartmentNumber);
			this.Controls.Add(this.lblDateOfBirth);
			this.Controls.Add(this.lblAppartmentNumber);
			this.Controls.Add(this.lblStreet);
			this.Controls.Add(this.lblCity);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.txtIDNumber);
			this.Controls.Add(this.lblIDNumber);
			this.Name = "FrmMemberChange";
			this.Text = "פרטי מנוי";
			((System.ComponentModel.ISupportInitialize)(this.errorProviderMemberChange)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtAppartmentNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAppartmentNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.DateTimePicker dtmDateOfBirth;
        private System.Windows.Forms.ErrorProvider errorProviderMemberChange;
		private System.Windows.Forms.PictureBox pbxLogo;
		private System.Windows.Forms.ComboBox txtAmountOfBooks;
		private System.Windows.Forms.Label lblAmountOfBooks;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.MaskedTextBox txtPhoneNumber;
	}
}