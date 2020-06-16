namespace Library.Gui
{
    partial class FrmAudiences
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAudiences));
			this.dgvAudience = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.pnlAddOrUpdate = new System.Windows.Forms.Panel();
			this.btnAddSave = new System.Windows.Forms.Button();
			this.txtAudienceName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblCodeLable = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdateOrDeleteSave = new System.Windows.Forms.Button();
			this.errorProviderAudience = new System.Windows.Forms.ErrorProvider(this.components);
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvAudience)).BeginInit();
			this.pnlAddOrUpdate.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAudience)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAudience
			// 
			this.dgvAudience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAudience.Location = new System.Drawing.Point(37, 156);
			this.dgvAudience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvAudience.MultiSelect = false;
			this.dgvAudience.Name = "dgvAudience";
			this.dgvAudience.ReadOnly = true;
			this.dgvAudience.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvAudience.RowHeadersWidth = 51;
			this.dgvAudience.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAudience.Size = new System.Drawing.Size(340, 416);
			this.dgvAudience.TabIndex = 0;
			this.dgvAudience.DoubleClick += new System.EventHandler(this.DgvAudience_DoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.White;
			this.btnAdd.Font = new System.Drawing.Font("Arial", 10F);
			this.btnAdd.Location = new System.Drawing.Point(302, 593);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 41);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "הוספה";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Arial", 10F);
			this.btnUpdate.Location = new System.Drawing.Point(214, 593);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(72, 41);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "עדכון";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
			// 
			// pnlAddOrUpdate
			// 
			this.pnlAddOrUpdate.BackColor = System.Drawing.Color.Transparent;
			this.pnlAddOrUpdate.Controls.Add(this.btnAddSave);
			this.pnlAddOrUpdate.Controls.Add(this.txtAudienceName);
			this.pnlAddOrUpdate.Controls.Add(this.lblName);
			this.pnlAddOrUpdate.Controls.Add(this.lblCode);
			this.pnlAddOrUpdate.Controls.Add(this.lblCodeLable);
			this.pnlAddOrUpdate.Font = new System.Drawing.Font("Arial", 10.2F);
			this.pnlAddOrUpdate.Location = new System.Drawing.Point(37, 650);
			this.pnlAddOrUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pnlAddOrUpdate.Name = "pnlAddOrUpdate";
			this.pnlAddOrUpdate.Size = new System.Drawing.Size(340, 111);
			this.pnlAddOrUpdate.TabIndex = 3;
			this.pnlAddOrUpdate.Visible = false;
			// 
			// btnAddSave
			// 
			this.btnAddSave.BackColor = System.Drawing.Color.White;
			this.btnAddSave.Font = new System.Drawing.Font("Arial", 10F);
			this.btnAddSave.Location = new System.Drawing.Point(13, 62);
			this.btnAddSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAddSave.Name = "btnAddSave";
			this.btnAddSave.Size = new System.Drawing.Size(72, 41);
			this.btnAddSave.TabIndex = 5;
			this.btnAddSave.Text = "אישור";
			this.btnAddSave.UseVisualStyleBackColor = false;
			this.btnAddSave.Click += new System.EventHandler(this.BtnAddSave_Click);
			// 
			// txtAudienceName
			// 
			this.txtAudienceName.Location = new System.Drawing.Point(100, 70);
			this.txtAudienceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAudienceName.Name = "txtAudienceName";
			this.txtAudienceName.Size = new System.Drawing.Size(132, 27);
			this.txtAudienceName.TabIndex = 3;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblName.Location = new System.Drawing.Point(245, 76);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(89, 19);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "שם קהל יעד";
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(173, 21);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(51, 19);
			this.lblCode.TabIndex = 1;
			this.lblCode.Text = "label2";
			// 
			// lblCodeLable
			// 
			this.lblCodeLable.AutoSize = true;
			this.lblCodeLable.Font = new System.Drawing.Font("Arial", 10.2F);
			this.lblCodeLable.Location = new System.Drawing.Point(293, 21);
			this.lblCodeLable.Name = "lblCodeLable";
			this.lblCodeLable.Size = new System.Drawing.Size(30, 19);
			this.lblCodeLable.TabIndex = 0;
			this.lblCodeLable.Text = "קוד";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 10F);
			this.btnDelete.Location = new System.Drawing.Point(122, 593);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(72, 41);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "מחיקה";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnUpdateOrDeleteSave
			// 
			this.btnUpdateOrDeleteSave.BackColor = System.Drawing.Color.White;
			this.btnUpdateOrDeleteSave.Font = new System.Drawing.Font("Arial", 10F);
			this.btnUpdateOrDeleteSave.Location = new System.Drawing.Point(37, 593);
			this.btnUpdateOrDeleteSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdateOrDeleteSave.Name = "btnUpdateOrDeleteSave";
			this.btnUpdateOrDeleteSave.Size = new System.Drawing.Size(72, 41);
			this.btnUpdateOrDeleteSave.TabIndex = 6;
			this.btnUpdateOrDeleteSave.Text = "אישור";
			this.btnUpdateOrDeleteSave.UseVisualStyleBackColor = false;
			this.btnUpdateOrDeleteSave.Visible = false;
			// 
			// errorProviderAudience
			// 
			this.errorProviderAudience.ContainerControl = this;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_2;
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(137, 22);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 7;
			this.pbxLogo.TabStop = false;
			// 
			// FrmAudiences
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(413, 795);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.btnUpdateOrDeleteSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.pnlAddOrUpdate);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvAudience);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmAudiences";
			this.Text = "קהלי יעד";
			((System.ComponentModel.ISupportInitialize)(this.dgvAudience)).EndInit();
			this.pnlAddOrUpdate.ResumeLayout(false);
			this.pnlAddOrUpdate.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderAudience)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAudience;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlAddOrUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCodeLable;
        private System.Windows.Forms.TextBox txtAudienceName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnUpdateOrDeleteSave;
        private System.Windows.Forms.ErrorProvider errorProviderAudience;
		private System.Windows.Forms.PictureBox pbxLogo;
	}
}