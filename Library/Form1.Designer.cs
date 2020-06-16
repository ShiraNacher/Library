namespace Library
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnAudience = new System.Windows.Forms.Button();
			this.btnAuthor = new System.Windows.Forms.Button();
			this.btnBooks = new System.Windows.Forms.Button();
			this.btnBooksBeingBorrowed = new System.Windows.Forms.Button();
			this.btnMembers = new System.Windows.Forms.Button();
			this.btnOrders = new System.Windows.Forms.Button();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAudience
			// 
			this.btnAudience.BackColor = System.Drawing.Color.White;
			this.btnAudience.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAudience.Font = new System.Drawing.Font("Arial", 12F);
			this.btnAudience.Location = new System.Drawing.Point(601, 163);
			this.btnAudience.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAudience.Name = "btnAudience";
			this.btnAudience.Size = new System.Drawing.Size(132, 59);
			this.btnAudience.TabIndex = 0;
			this.btnAudience.Text = "קהלי יעד";
			this.btnAudience.UseVisualStyleBackColor = false;
			this.btnAudience.Click += new System.EventHandler(this.BtnAudience_Click);
			// 
			// btnAuthor
			// 
			this.btnAuthor.BackColor = System.Drawing.Color.White;
			this.btnAuthor.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAuthor.Font = new System.Drawing.Font("Arial", 12F);
			this.btnAuthor.Location = new System.Drawing.Point(441, 163);
			this.btnAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAuthor.Name = "btnAuthor";
			this.btnAuthor.Size = new System.Drawing.Size(132, 59);
			this.btnAuthor.TabIndex = 1;
			this.btnAuthor.Text = "סופרים";
			this.btnAuthor.UseVisualStyleBackColor = false;
			this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
			// 
			// btnBooks
			// 
			this.btnBooks.BackColor = System.Drawing.Color.White;
			this.btnBooks.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnBooks.Font = new System.Drawing.Font("Arial", 12F);
			this.btnBooks.Location = new System.Drawing.Point(441, 256);
			this.btnBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBooks.Name = "btnBooks";
			this.btnBooks.Size = new System.Drawing.Size(132, 59);
			this.btnBooks.TabIndex = 2;
			this.btnBooks.Text = "ספרים";
			this.btnBooks.UseVisualStyleBackColor = false;
			this.btnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
			// 
			// btnBooksBeingBorrowed
			// 
			this.btnBooksBeingBorrowed.BackColor = System.Drawing.Color.White;
			this.btnBooksBeingBorrowed.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnBooksBeingBorrowed.Font = new System.Drawing.Font("Arial", 12F);
			this.btnBooksBeingBorrowed.Location = new System.Drawing.Point(441, 74);
			this.btnBooksBeingBorrowed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBooksBeingBorrowed.Name = "btnBooksBeingBorrowed";
			this.btnBooksBeingBorrowed.Size = new System.Drawing.Size(132, 59);
			this.btnBooksBeingBorrowed.TabIndex = 3;
			this.btnBooksBeingBorrowed.Text = "השאלת ספרים";
			this.btnBooksBeingBorrowed.UseVisualStyleBackColor = false;
			this.btnBooksBeingBorrowed.Click += new System.EventHandler(this.BtnBooksBeingBorrowed_Click);
			// 
			// btnMembers
			// 
			this.btnMembers.BackColor = System.Drawing.Color.White;
			this.btnMembers.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnMembers.Font = new System.Drawing.Font("Arial", 12F);
			this.btnMembers.Location = new System.Drawing.Point(601, 74);
			this.btnMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMembers.Name = "btnMembers";
			this.btnMembers.Size = new System.Drawing.Size(132, 59);
			this.btnMembers.TabIndex = 6;
			this.btnMembers.Text = "מנויים";
			this.btnMembers.UseVisualStyleBackColor = false;
			this.btnMembers.Click += new System.EventHandler(this.BtnMembers_Click);
			// 
			// btnOrders
			// 
			this.btnOrders.BackColor = System.Drawing.Color.White;
			this.btnOrders.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOrders.Font = new System.Drawing.Font("Arial", 12F);
			this.btnOrders.Location = new System.Drawing.Point(601, 256);
			this.btnOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new System.Drawing.Size(132, 59);
			this.btnOrders.TabIndex = 8;
			this.btnOrders.Text = "הזמנות";
			this.btnOrders.UseVisualStyleBackColor = false;
			// 
			// pbxLogo
			// 
			this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
			this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pbxLogo.ErrorImage = global::Library.Properties.Resources.Library_logo___final_smaller;
			this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
			this.pbxLogo.Location = new System.Drawing.Point(52, 52);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(325, 275);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 12;
			this.pbxLogo.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Library.Properties.Resources.gradiant___white_blue_purple_4;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(811, 399);
			this.Controls.Add(this.pbxLogo);
			this.Controls.Add(this.btnOrders);
			this.Controls.Add(this.btnMembers);
			this.Controls.Add(this.btnBooksBeingBorrowed);
			this.Controls.Add(this.btnBooks);
			this.Controls.Add(this.btnAuthor);
			this.Controls.Add(this.btnAudience);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAudience;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnBooksBeingBorrowed;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnOrders;
		private System.Windows.Forms.PictureBox pbxLogo;
	}
}

