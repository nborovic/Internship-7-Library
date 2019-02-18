namespace Library.Presentation.Forms.AuthorForms
{
    partial class AuthorDetails
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
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.authorFullName = new System.Windows.Forms.TextBox();
            this.authorBooks = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booksListBox
            // 
            this.booksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(30, 70);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(290, 264);
            this.booksListBox.TabIndex = 0;
            // 
            // authorFullName
            // 
            this.authorFullName.BackColor = System.Drawing.SystemColors.Menu;
            this.authorFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorFullName.Location = new System.Drawing.Point(30, 23);
            this.authorFullName.Name = "authorFullName";
            this.authorFullName.ReadOnly = true;
            this.authorFullName.Size = new System.Drawing.Size(290, 24);
            this.authorFullName.TabIndex = 1;
            this.authorFullName.Text = "Placeholder";
            this.authorFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // authorBooks
            // 
            this.authorBooks.AutoSize = true;
            this.authorBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorBooks.Location = new System.Drawing.Point(27, 50);
            this.authorBooks.Name = "authorBooks";
            this.authorBooks.Size = new System.Drawing.Size(46, 15);
            this.authorBooks.TabIndex = 2;
            this.authorBooks.Text = "Books";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(147, 344);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // AuthorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 377);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.authorBooks);
            this.Controls.Add(this.authorFullName);
            this.Controls.Add(this.booksListBox);
            this.Name = "AuthorDetails";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.TextBox authorFullName;
        private System.Windows.Forms.Label authorBooks;
        private System.Windows.Forms.Button backButton;
    }
}