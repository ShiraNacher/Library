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
            this.btnAudience = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnBooksBeingBorrowed = new System.Windows.Forms.Button();
            this.btnBookType = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btnMembership = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAudience
            // 
            this.btnAudience.Location = new System.Drawing.Point(180, 105);
            this.btnAudience.Name = "btnAudience";
            this.btnAudience.Size = new System.Drawing.Size(132, 59);
            this.btnAudience.TabIndex = 0;
            this.btnAudience.Text = "Audience";
            this.btnAudience.UseVisualStyleBackColor = true;
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(180, 188);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(132, 59);
            this.btnAuthor.TabIndex = 1;
            this.btnAuthor.Text = "סופרים";
            this.btnAuthor.UseVisualStyleBackColor = true;
            // 
            // btnBooks
            // 
            this.btnBooks.Location = new System.Drawing.Point(180, 276);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(132, 59);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "ספרים";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // btnBooksBeingBorrowed
            // 
            this.btnBooksBeingBorrowed.Location = new System.Drawing.Point(337, 105);
            this.btnBooksBeingBorrowed.Name = "btnBooksBeingBorrowed";
            this.btnBooksBeingBorrowed.Size = new System.Drawing.Size(132, 59);
            this.btnBooksBeingBorrowed.TabIndex = 3;
            this.btnBooksBeingBorrowed.Text = "books being borrowed";
            this.btnBooksBeingBorrowed.UseVisualStyleBackColor = true;
            // 
            // btnBookType
            // 
            this.btnBookType.Location = new System.Drawing.Point(337, 188);
            this.btnBookType.Name = "btnBookType";
            this.btnBookType.Size = new System.Drawing.Size(132, 59);
            this.btnBookType.TabIndex = 4;
            this.btnBookType.Text = "book type";
            this.btnBookType.UseVisualStyleBackColor = true;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(337, 276);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(132, 59);
            this.btnBorrowBook.TabIndex = 5;
            this.btnBorrowBook.Text = "boorow bok";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            // 
            // btnMembers
            // 
            this.btnMembers.Location = new System.Drawing.Point(493, 105);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(132, 59);
            this.btnMembers.TabIndex = 6;
            this.btnMembers.Text = "מנויים";
            this.btnMembers.UseVisualStyleBackColor = true;
            // 
            // btnMembership
            // 
            this.btnMembership.Location = new System.Drawing.Point(493, 188);
            this.btnMembership.Name = "btnMembership";
            this.btnMembership.Size = new System.Drawing.Size(132, 59);
            this.btnMembership.TabIndex = 7;
            this.btnMembership.Text = "צקצנקרדיןפ";
            this.btnMembership.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(493, 276);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(132, 59);
            this.btnOrders.TabIndex = 8;
            this.btnOrders.Text = "הזמנות";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnMembership);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnBookType);
            this.Controls.Add(this.btnBooksBeingBorrowed);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnAudience);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAudience;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnBooksBeingBorrowed;
        private System.Windows.Forms.Button btnBookType;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnMembers;
        private System.Windows.Forms.Button btnMembership;
        private System.Windows.Forms.Button btnOrders;
    }
}

