namespace Library.Gui
{
    partial class FrmAuthors
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthors));
			this.dgvAuthors = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.pnlAddOrUpdate = new System.Windows.Forms.Panel();
			this.txtAuthorFirstName = new System.Windows.Forms.TextBox();
			this.lblAuthorFirstName = new System.Windows.Forms.Label();
			this.btnOk = new System.Windows.Forms.Button();
			this.txtAuthorLastName = new System.Windows.Forms.TextBox();
			this.lblAuthorLastName = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblCodeLable = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			this.errorProviderAuthors = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
			this.pnlAddOrUpdate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthors)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAuthors
			// 
			this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAuthors.Location = new System.Drawing.Point(195, 30);
			this.dgvAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvAuthors.MultiSelect = false;
			this.dgvAuthors.Name = "dgvAuthors";
			this.dgvAuthors.ReadOnly = true;
			this.dgvAuthors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvAuthors.RowHeadersWidth = 51;
			this.dgvAuthors.RowTemplate.Height = 24;
			this.dgvAuthors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAuthors.Size = new System.Drawing.Size(471, 450);
			this.dgvAuthors.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.White;
			this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
			this.btnAdd.Location = new System.Drawing.Point(73, 186);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(91, 47);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "הוספה";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F);
			this.btnUpdate.Location = new System.Drawing.Point(73, 250);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(91, 47);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "עדכון";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// pnlAddOrUpdate
			// 
			this.pnlAddOrUpdate.BackColor = System.Drawing.Color.MediumOrchid;
			this.pnlAddOrUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlAddOrUpdate.Controls.Add(this.txtAuthorFirstName);
			this.pnlAddOrUpdate.Controls.Add(this.lblAuthorFirstName);
			this.pnlAddOrUpdate.Controls.Add(this.btnOk);
			this.pnlAddOrUpdate.Controls.Add(this.txtAuthorLastName);
			this.pnlAddOrUpdate.Controls.Add(this.lblAuthorLastName);
			this.pnlAddOrUpdate.Controls.Add(this.lblCode);
			this.pnlAddOrUpdate.Controls.Add(this.lblCodeLable);
			this.pnlAddOrUpdate.Font = new System.Drawing.Font("Arial", 10.2F);
			this.pnlAddOrUpdate.Location = new System.Drawing.Point(222, 514);
			this.pnlAddOrUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlAddOrUpdate.Name = "pnlAddOrUpdate";
			this.pnlAddOrUpdate.Size = new System.Drawing.Size(427, 154);
			this.pnlAddOrUpdate.TabIndex = 3;
			this.pnlAddOrUpdate.Visible = false;
			// 
			// txtAuthorFirstName
			// 
			this.txtAuthorFirstName.Location = new System.Drawing.Point(173, 112);
			this.txtAuthorFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAuthorFirstName.Name = "txtAuthorFirstName";
			this.txtAuthorFirstName.Size = new System.Drawing.Size(123, 27);
			this.txtAuthorFirstName.TabIndex = 14;
			// 
			// lblAuthorFirstName
			// 
			this.lblAuthorFirstName.AutoSize = true;
			this.lblAuthorFirstName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAuthorFirstName.Location = new System.Drawing.Point(339, 115);
			this.lblAuthorFirstName.Name = "lblAuthorFirstName";
			this.lblAuthorFirstName.Size = new System.Drawing.Size(67, 19);
			this.lblAuthorFirstName.TabIndex = 13;
			this.lblAuthorFirstName.Text = "שם פרטי";
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.White;
			this.btnOk.Font = new System.Drawing.Font("Arial", 12F);
			this.btnOk.Location = new System.Drawing.Point(18, 89);
			this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(91, 47);
			this.btnOk.TabIndex = 12;
			this.btnOk.Text = "אישור";
			this.btnOk.UseVisualStyleBackColor = false;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// txtAuthorLastName
			// 
			this.txtAuthorLastName.Location = new System.Drawing.Point(173, 77);
			this.txtAuthorLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAuthorLastName.Name = "txtAuthorLastName";
			this.txtAuthorLastName.Size = new System.Drawing.Size(123, 27);
			this.txtAuthorLastName.TabIndex = 3;
			// 
			// lblAuthorLastName
			// 
			this.lblAuthorLastName.AutoSize = true;
			this.lblAuthorLastName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblAuthorLastName.Location = new System.Drawing.Point(319, 77);
			this.lblAuthorLastName.Name = "lblAuthorLastName";
			this.lblAuthorLastName.Size = new System.Drawing.Size(87, 19);
			this.lblAuthorLastName.TabIndex = 2;
			this.lblAuthorLastName.Text = "שם משפחה";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(250, 35);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(51, 19);
			this.lblCode.TabIndex = 1;
			this.lblCode.Text = "label2";
			// 
			// lblCodeLable
			// 
			this.lblCodeLable.AutoSize = true;
			this.lblCodeLable.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblCodeLable.Location = new System.Drawing.Point(356, 35);
			this.lblCodeLable.Name = "lblCodeLable";
			this.lblCodeLable.Size = new System.Drawing.Size(30, 19);
			this.lblCodeLable.TabIndex = 0;
			this.lblCodeLable.Text = "קוד";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 12F);
			this.btnDelete.Location = new System.Drawing.Point(73, 313);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(91, 47);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "מחיקה";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(24, 30);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 11;
			this.pbxLogo.TabStop = false;
			// 
			// errorProviderAuthors
			// 
			this.errorProviderAuthors.ContainerControl = this;
			// 
			// FrmAuthors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(703, 679);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.pnlAddOrUpdate);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAuthors);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmAuthors";
			this.Text = "סופרים";
			((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
			this.pnlAddOrUpdate.ResumeLayout(false);
			this.pnlAddOrUpdate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthors)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlAddOrUpdate;
        private System.Windows.Forms.TextBox txtAuthorLastName;
        private System.Windows.Forms.Label lblAuthorLastName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCodeLable;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.PictureBox pbxLogo;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox txtAuthorFirstName;
		private System.Windows.Forms.Label lblAuthorFirstName;
		private System.Windows.Forms.ErrorProvider errorProviderAuthors;
	}
}