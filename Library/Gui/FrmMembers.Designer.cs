namespace Library.Gui
{
    partial class FrmMembers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMembers));
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dgvMembers = new System.Windows.Forms.DataGridView();
			this.btnOk = new System.Windows.Forms.Button();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.White;
			this.btnDelete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(194, 486);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(113, 49);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "מחיקה";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.White;
			this.btnUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(355, 486);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(113, 49);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "עדכון";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.White;
			this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(519, 486);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(113, 49);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "הוספה";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// dgvMembers
			// 
			this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMembers.Location = new System.Drawing.Point(27, 146);
			this.dgvMembers.MultiSelect = false;
			this.dgvMembers.Name = "dgvMembers";
			this.dgvMembers.ReadOnly = true;
			this.dgvMembers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvMembers.RowHeadersWidth = 51;
			this.dgvMembers.RowTemplate.Height = 24;
			this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMembers.Size = new System.Drawing.Size(740, 319);
			this.dgvMembers.TabIndex = 4;
			// 
			// btnOk
			// 
			this.btnOk.BackColor = System.Drawing.Color.White;
			this.btnOk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(37, 486);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(77, 49);
			this.btnOk.TabIndex = 8;
			this.btnOk.Text = "אישור";
			this.btnOk.UseVisualStyleBackColor = false;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(27, 12);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 11;
			this.pbxLogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(557, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 38);
			this.label1.TabIndex = 12;
			this.label1.Text = ":טבלת מנויים";
			// 
			// FrmMembers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 559);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvMembers);
			this.Name = "FrmMembers";
			this.Text = "טבלת מנויים";
			((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMembers;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.PictureBox pbxLogo;
		private System.Windows.Forms.Label label1;
	}
}