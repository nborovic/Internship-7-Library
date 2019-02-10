namespace Library.Presentation.Forms
{
    partial class BookDetails
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
            this.bookName = new System.Windows.Forms.TextBox();
            this.bookGenre = new System.Windows.Forms.TextBox();
            this.numberOfPagesLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.BackColor = System.Drawing.SystemColors.Menu;
            this.bookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(69, 29);
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Size = new System.Drawing.Size(290, 24);
            this.bookName.TabIndex = 5;
            this.bookName.Text = "Placeholder";
            this.bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookGenre
            // 
            this.bookGenre.BackColor = System.Drawing.SystemColors.Menu;
            this.bookGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookGenre.Location = new System.Drawing.Point(69, 53);
            this.bookGenre.Name = "bookGenre";
            this.bookGenre.ReadOnly = true;
            this.bookGenre.Size = new System.Drawing.Size(290, 17);
            this.bookGenre.TabIndex = 6;
            this.bookGenre.Text = "Placeholder";
            this.bookGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numberOfPagesLabel
            // 
            this.numberOfPagesLabel.AutoSize = true;
            this.numberOfPagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPagesLabel.Location = new System.Drawing.Point(65, 93);
            this.numberOfPagesLabel.Name = "numberOfPagesLabel";
            this.numberOfPagesLabel.Size = new System.Drawing.Size(139, 20);
            this.numberOfPagesLabel.TabIndex = 7;
            this.numberOfPagesLabel.Text = "Number of pages: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(65, 113);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 20);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author: ";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(65, 133);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(82, 20);
            this.publisherLabel.TabIndex = 9;
            this.publisherLabel.Text = "Publisher: ";
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 171);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.numberOfPagesLabel);
            this.Controls.Add(this.bookGenre);
            this.Controls.Add(this.bookName);
            this.Name = "BookDetails";
            this.Text = "BookDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox bookGenre;
        private System.Windows.Forms.Label numberOfPagesLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
    }
}