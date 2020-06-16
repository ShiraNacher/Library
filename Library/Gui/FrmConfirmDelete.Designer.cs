namespace Library.Gui
{
	partial class FrmConfirmDelete
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
			this.btnNo = new System.Windows.Forms.Button();
			this.lblConfirmDelete = new System.Windows.Forms.Label();
			this.btnYes = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNo
			// 
			this.btnNo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNo.Location = new System.Drawing.Point(201, 238);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(80, 48);
			this.btnNo.TabIndex = 0;
			this.btnNo.Text = "לא";
			this.btnNo.UseVisualStyleBackColor = true;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// lblConfirmDelete
			// 
			this.lblConfirmDelete.AutoSize = true;
			this.lblConfirmDelete.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmDelete.Location = new System.Drawing.Point(53, 102);
			this.lblConfirmDelete.Name = "lblConfirmDelete";
			this.lblConfirmDelete.Size = new System.Drawing.Size(77, 27);
			this.lblConfirmDelete.TabIndex = 1;
			this.lblConfirmDelete.Text = "label1";
			// 
			// btnYes
			// 
			this.btnYes.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnYes.Location = new System.Drawing.Point(314, 238);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(80, 48);
			this.btnYes.TabIndex = 2;
			this.btnYes.Text = "כן";
			this.btnYes.UseVisualStyleBackColor = true;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// FrmConfirmDelete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 318);
			this.Controls.Add(this.btnYes);
			this.Controls.Add(this.lblConfirmDelete);
			this.Controls.Add(this.btnNo);
			this.Name = "FrmConfirmDelete";
			this.Text = "FrmConfirmDelete";
			this.Load += new System.EventHandler(this.FrmConfirmDelete_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Label lblConfirmDelete;
		private System.Windows.Forms.Button btnYes;
	}
}