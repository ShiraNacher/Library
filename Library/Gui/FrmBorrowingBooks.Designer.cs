namespace Library.Gui
{
    partial class FrmBorrowingBooks
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorrowingBooks));
			this.gbxSearch = new System.Windows.Forms.GroupBox();
			this.lblSearchByName = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblSearchByID = new System.Windows.Forms.Label();
			this.txtSearchByName = new System.Windows.Forms.ComboBox();
			this.txtSearchByID = new System.Windows.Forms.TextBox();
			this.gbxInfo = new System.Windows.Forms.GroupBox();
			this.lblAmountOfBooks = new System.Windows.Forms.Label();
			this.txtAmountOfBooks = new System.Windows.Forms.TextBox();
			this.lblReaderPhoneNumber = new System.Windows.Forms.Label();
			this.lblReaderID = new System.Windows.Forms.Label();
			this.lblReaderName = new System.Windows.Forms.Label();
			this.txtReaderPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtReaderID = new System.Windows.Forms.TextBox();
			this.txtReaderName = new System.Windows.Forms.TextBox();
			this.listVeiwBorrowing = new System.Windows.Forms.ListView();
			this.lblComments = new System.Windows.Forms.Label();
			this.txtComments = new System.Windows.Forms.TextBox();
			this.btnAddBook = new System.Windows.Forms.Button();
			this.txtNewBookCode = new System.Windows.Forms.TextBox();
			this.lblBorrowBook = new System.Windows.Forms.Label();
			this.chbReturn = new System.Windows.Forms.CheckedListBox();
			this.lblReturn = new System.Windows.Forms.Label();
			this.errorProviderBooks = new System.Windows.Forms.ErrorProvider(this.components);
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveChanges = new System.Windows.Forms.Button();
			this.gbxSearch.SuspendLayout();
			this.gbxInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxSearch
			// 
			this.gbxSearch.BackColor = System.Drawing.SystemColors.ControlLight;
			this.gbxSearch.Controls.Add(this.lblSearchByName);
			this.gbxSearch.Controls.Add(this.btnSearch);
			this.gbxSearch.Controls.Add(this.lblSearchByID);
			this.gbxSearch.Controls.Add(this.txtSearchByName);
			this.gbxSearch.Controls.Add(this.txtSearchByID);
			this.gbxSearch.Font = new System.Drawing.Font("Arial", 10.2F);
			this.gbxSearch.Location = new System.Drawing.Point(343, 39);
			this.gbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxSearch.Name = "gbxSearch";
			this.gbxSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbxSearch.Size = new System.Drawing.Size(507, 70);
			this.gbxSearch.TabIndex = 0;
			this.gbxSearch.TabStop = false;
			this.gbxSearch.Text = "חיפוש";
			// 
			// lblSearchByName
			// 
			this.lblSearchByName.AutoSize = true;
			this.lblSearchByName.Location = new System.Drawing.Point(276, 27);
			this.lblSearchByName.Name = "lblSearchByName";
			this.lblSearchByName.Size = new System.Drawing.Size(31, 19);
			this.lblSearchByName.TabIndex = 8;
			this.lblSearchByName.Text = "שם";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(19, 19);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(65, 34);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "אישור";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.Button1_Click);
			// 
			// lblSearchByID
			// 
			this.lblSearchByID.AutoSize = true;
			this.lblSearchByID.Location = new System.Drawing.Point(456, 29);
			this.lblSearchByID.Name = "lblSearchByID";
			this.lblSearchByID.Size = new System.Drawing.Size(33, 19);
			this.lblSearchByID.TabIndex = 6;
			this.lblSearchByID.Text = "ת\"ז";
			// 
			// txtSearchByName
			// 
			this.txtSearchByName.FormattingEnabled = true;
			this.txtSearchByName.Location = new System.Drawing.Point(107, 24);
			this.txtSearchByName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSearchByName.Name = "txtSearchByName";
			this.txtSearchByName.Size = new System.Drawing.Size(164, 27);
			this.txtSearchByName.TabIndex = 2;
			this.txtSearchByName.SelectedIndexChanged += new System.EventHandler(this.TxtSearchByName_SelectedIndexChanged);
			// 
			// txtSearchByID
			// 
			this.txtSearchByID.Location = new System.Drawing.Point(325, 26);
			this.txtSearchByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSearchByID.Name = "txtSearchByID";
			this.txtSearchByID.Size = new System.Drawing.Size(125, 27);
			this.txtSearchByID.TabIndex = 0;
			this.txtSearchByID.TextChanged += new System.EventHandler(this.txtSearchByID_TextChanged);
			// 
			// gbxInfo
			// 
			this.gbxInfo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.gbxInfo.Controls.Add(this.lblAmountOfBooks);
			this.gbxInfo.Controls.Add(this.txtAmountOfBooks);
			this.gbxInfo.Controls.Add(this.lblReaderPhoneNumber);
			this.gbxInfo.Controls.Add(this.lblReaderID);
			this.gbxInfo.Controls.Add(this.lblReaderName);
			this.gbxInfo.Controls.Add(this.txtReaderPhoneNumber);
			this.gbxInfo.Controls.Add(this.txtReaderID);
			this.gbxInfo.Controls.Add(this.txtReaderName);
			this.gbxInfo.Font = new System.Drawing.Font("Arial", 10.2F);
			this.gbxInfo.Location = new System.Drawing.Point(577, 116);
			this.gbxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInfo.Name = "gbxInfo";
			this.gbxInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gbxInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbxInfo.Size = new System.Drawing.Size(273, 151);
			this.gbxInfo.TabIndex = 1;
			this.gbxInfo.TabStop = false;
			this.gbxInfo.Text = "פרטי מנוי";
			// 
			// lblAmountOfBooks
			// 
			this.lblAmountOfBooks.AutoSize = true;
			this.lblAmountOfBooks.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAmountOfBooks.Location = new System.Drawing.Point(176, 117);
			this.lblAmountOfBooks.Name = "lblAmountOfBooks";
			this.lblAmountOfBooks.Size = new System.Drawing.Size(78, 19);
			this.lblAmountOfBooks.TabIndex = 13;
			this.lblAmountOfBooks.Text = "מס\' ספרים";
			// 
			// txtAmountOfBooks
			// 
			this.txtAmountOfBooks.Enabled = false;
			this.txtAmountOfBooks.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtAmountOfBooks.Location = new System.Drawing.Point(45, 115);
			this.txtAmountOfBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAmountOfBooks.Name = "txtAmountOfBooks";
			this.txtAmountOfBooks.Size = new System.Drawing.Size(113, 27);
			this.txtAmountOfBooks.TabIndex = 12;
			// 
			// lblReaderPhoneNumber
			// 
			this.lblReaderPhoneNumber.AutoSize = true;
			this.lblReaderPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblReaderPhoneNumber.Location = new System.Drawing.Point(212, 87);
			this.lblReaderPhoneNumber.Name = "lblReaderPhoneNumber";
			this.lblReaderPhoneNumber.Size = new System.Drawing.Size(42, 19);
			this.lblReaderPhoneNumber.TabIndex = 11;
			this.lblReaderPhoneNumber.Text = "טלפון";
			// 
			// lblReaderID
			// 
			this.lblReaderID.AutoSize = true;
			this.lblReaderID.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblReaderID.Location = new System.Drawing.Point(221, 60);
			this.lblReaderID.Name = "lblReaderID";
			this.lblReaderID.Size = new System.Drawing.Size(33, 19);
			this.lblReaderID.TabIndex = 10;
			this.lblReaderID.Text = "ת\"ז";
			// 
			// lblReaderName
			// 
			this.lblReaderName.AutoSize = true;
			this.lblReaderName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblReaderName.Location = new System.Drawing.Point(187, 31);
			this.lblReaderName.Name = "lblReaderName";
			this.lblReaderName.Size = new System.Drawing.Size(67, 19);
			this.lblReaderName.TabIndex = 9;
			this.lblReaderName.Text = "שם קורא";
			// 
			// txtReaderPhoneNumber
			// 
			this.txtReaderPhoneNumber.Enabled = false;
			this.txtReaderPhoneNumber.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtReaderPhoneNumber.Location = new System.Drawing.Point(45, 86);
			this.txtReaderPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtReaderPhoneNumber.Name = "txtReaderPhoneNumber";
			this.txtReaderPhoneNumber.Size = new System.Drawing.Size(113, 27);
			this.txtReaderPhoneNumber.TabIndex = 5;
			// 
			// txtReaderID
			// 
			this.txtReaderID.Enabled = false;
			this.txtReaderID.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtReaderID.Location = new System.Drawing.Point(45, 57);
			this.txtReaderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtReaderID.Name = "txtReaderID";
			this.txtReaderID.Size = new System.Drawing.Size(113, 27);
			this.txtReaderID.TabIndex = 4;
			// 
			// txtReaderName
			// 
			this.txtReaderName.Enabled = false;
			this.txtReaderName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtReaderName.Location = new System.Drawing.Point(45, 28);
			this.txtReaderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtReaderName.Name = "txtReaderName";
			this.txtReaderName.Size = new System.Drawing.Size(113, 27);
			this.txtReaderName.TabIndex = 3;
			// 
			// listVeiwBorrowing
			// 
			this.listVeiwBorrowing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listVeiwBorrowing.Font = new System.Drawing.Font("Arial", 10.2F);
			this.listVeiwBorrowing.FullRowSelect = true;
			this.listVeiwBorrowing.GridLines = true;
			this.listVeiwBorrowing.HideSelection = false;
			this.listVeiwBorrowing.Location = new System.Drawing.Point(120, 296);
			this.listVeiwBorrowing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listVeiwBorrowing.MultiSelect = false;
			this.listVeiwBorrowing.Name = "listVeiwBorrowing";
			this.listVeiwBorrowing.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.listVeiwBorrowing.RightToLeftLayout = true;
			this.listVeiwBorrowing.Size = new System.Drawing.Size(855, 189);
			this.listVeiwBorrowing.TabIndex = 2;
			this.listVeiwBorrowing.UseCompatibleStateImageBehavior = false;
			this.listVeiwBorrowing.View = System.Windows.Forms.View.Details;
			// 
			// lblComments
			// 
			this.lblComments.AutoSize = true;
			this.lblComments.BackColor = System.Drawing.Color.Transparent;
			this.lblComments.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblComments.Location = new System.Drawing.Point(458, 116);
			this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblComments.Name = "lblComments";
			this.lblComments.Size = new System.Drawing.Size(56, 19);
			this.lblComments.TabIndex = 3;
			this.lblComments.Text = ":הערות";
			// 
			// txtComments
			// 
			this.txtComments.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtComments.Location = new System.Drawing.Point(205, 144);
			this.txtComments.Margin = new System.Windows.Forms.Padding(4);
			this.txtComments.Multiline = true;
			this.txtComments.Name = "txtComments";
			this.txtComments.Size = new System.Drawing.Size(300, 123);
			this.txtComments.TabIndex = 4;
			// 
			// btnAddBook
			// 
			this.btnAddBook.BackColor = System.Drawing.Color.White;
			this.btnAddBook.Font = new System.Drawing.Font("Arial", 12F);
			this.btnAddBook.Location = new System.Drawing.Point(16, 53);
			this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
			this.btnAddBook.Name = "btnAddBook";
			this.btnAddBook.Size = new System.Drawing.Size(100, 44);
			this.btnAddBook.TabIndex = 5;
			this.btnAddBook.Text = "הוספה";
			this.btnAddBook.UseVisualStyleBackColor = false;
			this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
			// 
			// txtNewBookCode
			// 
			this.txtNewBookCode.Font = new System.Drawing.Font("Arial", 10.2F);
			this.txtNewBookCode.Location = new System.Drawing.Point(128, 64);
			this.txtNewBookCode.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewBookCode.Name = "txtNewBookCode";
			this.txtNewBookCode.Size = new System.Drawing.Size(169, 27);
			this.txtNewBookCode.TabIndex = 6;
			// 
			// lblBorrowBook
			// 
			this.lblBorrowBook.AutoSize = true;
			this.lblBorrowBook.BackColor = System.Drawing.Color.Transparent;
			this.lblBorrowBook.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblBorrowBook.Location = new System.Drawing.Point(203, 29);
			this.lblBorrowBook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBorrowBook.Name = "lblBorrowBook";
			this.lblBorrowBook.Size = new System.Drawing.Size(98, 19);
			this.lblBorrowBook.TabIndex = 7;
			this.lblBorrowBook.Text = ":השאלת ספר";
			// 
			// chbReturn
			// 
			this.chbReturn.Font = new System.Drawing.Font("Arial", 10.2F);
			this.chbReturn.FormattingEnabled = true;
			this.chbReturn.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
			this.chbReturn.Location = new System.Drawing.Point(994, 349);
			this.chbReturn.Name = "chbReturn";
			this.chbReturn.Size = new System.Drawing.Size(24, 136);
			this.chbReturn.TabIndex = 8;
			// 
			// lblReturn
			// 
			this.lblReturn.AutoSize = true;
			this.lblReturn.BackColor = System.Drawing.Color.Transparent;
			this.lblReturn.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblReturn.Location = new System.Drawing.Point(991, 316);
			this.lblReturn.Name = "lblReturn";
			this.lblReturn.Size = new System.Drawing.Size(55, 19);
			this.lblReturn.TabIndex = 9;
			this.lblReturn.Text = "החזרה";
			// 
			// errorProviderBooks
			// 
			this.errorProviderBooks.ContainerControl = this;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(31, 28);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 10;
			this.pbxLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 10.2F);
			this.label1.Location = new System.Drawing.Point(305, 68);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = ":קוד ספר";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lblBorrowBook);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNewBookCode);
			this.panel1.Controls.Add(this.btnAddBook);
			this.panel1.Location = new System.Drawing.Point(548, 506);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(388, 127);
			this.panel1.TabIndex = 12;
			// 
			// btnSaveChanges
			// 
			this.btnSaveChanges.BackColor = System.Drawing.Color.White;
			this.btnSaveChanges.Font = new System.Drawing.Font("Arial", 12F);
			this.btnSaveChanges.Location = new System.Drawing.Point(241, 536);
			this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4);
			this.btnSaveChanges.Name = "btnSaveChanges";
			this.btnSaveChanges.Size = new System.Drawing.Size(100, 44);
			this.btnSaveChanges.TabIndex = 12;
			this.btnSaveChanges.Text = "אישור";
			this.btnSaveChanges.UseVisualStyleBackColor = false;
			// 
			// FrmBorrowingBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1134, 657);
			this.Controls.Add(this.btnSaveChanges);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.lblReturn);
			this.Controls.Add(this.chbReturn);
			this.Controls.Add(this.txtComments);
			this.Controls.Add(this.lblComments);
			this.Controls.Add(this.listVeiwBorrowing);
			this.Controls.Add(this.gbxInfo);
			this.Controls.Add(this.gbxSearch);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmBorrowingBooks";
			this.Text = "השאלת ספר למנוי";
			this.gbxSearch.ResumeLayout(false);
			this.gbxSearch.PerformLayout();
			this.gbxInfo.ResumeLayout(false);
			this.gbxInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ComboBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByID;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.TextBox txtReaderPhoneNumber;
        private System.Windows.Forms.TextBox txtReaderID;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.Label lblSearchByID;
        private System.Windows.Forms.Label lblReaderPhoneNumber;
        private System.Windows.Forms.Label lblReaderID;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.ListView listVeiwBorrowing;
        private System.Windows.Forms.Label lblAmountOfBooks;
        private System.Windows.Forms.TextBox txtAmountOfBooks;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtNewBookCode;
        private System.Windows.Forms.Label lblBorrowBook;
		private System.Windows.Forms.CheckedListBox chbReturn;
		private System.Windows.Forms.Label lblReturn;
		private System.Windows.Forms.ErrorProvider errorProviderBooks;
		private System.Windows.Forms.PictureBox pbxLogo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSaveChanges;
	}
}