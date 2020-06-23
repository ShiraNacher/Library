namespace Library.Gui
{
	partial class FrmSearchResults
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchResults));
			this.dgvSearchResults = new System.Windows.Forms.DataGridView();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSearchResults
			// 
			this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearchResults.Location = new System.Drawing.Point(64, 161);
			this.dgvSearchResults.MultiSelect = false;
			this.dgvSearchResults.Name = "dgvSearchResults";
			this.dgvSearchResults.ReadOnly = true;
			this.dgvSearchResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvSearchResults.RowHeadersWidth = 51;
			this.dgvSearchResults.RowTemplate.Height = 24;
			this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSearchResults.Size = new System.Drawing.Size(902, 464);
			this.dgvSearchResults.TabIndex = 0;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(27, 22);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(140, 119);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 12;
			this.pbxLogo.TabStop = false;
			// 
			// FrmSearchResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_41;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1027, 662);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.dgvSearchResults);
			this.Name = "FrmSearchResults";
			this.Text = "FrmSearchResults";
			((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSearchResults;
		private System.Windows.Forms.PictureBox pbxLogo;
	}
}