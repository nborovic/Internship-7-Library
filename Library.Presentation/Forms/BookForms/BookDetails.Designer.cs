namespace Library.Presentation.Forms.BookForms
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
            this.rentedLabel = new System.Windows.Forms.Label();
            this.copiesColorIndicator = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookName
            // 
            this.bookName.BackColor = System.Drawing.SystemColors.Menu;
            this.bookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(21, 12);
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
            this.bookGenre.Location = new System.Drawing.Point(21, 36);
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
            this.numberOfPagesLabel.Location = new System.Drawing.Point(17, 76);
            this.numberOfPagesLabel.Name = "numberOfPagesLabel";
            this.numberOfPagesLabel.Size = new System.Drawing.Size(139, 20);
            this.numberOfPagesLabel.TabIndex = 7;
            this.numberOfPagesLabel.Text = "Number of pages: ";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorLabel.Location = new System.Drawing.Point(17, 96);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(65, 20);
            this.authorLabel.TabIndex = 8;
            this.authorLabel.Text = "Author: ";
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisherLabel.Location = new System.Drawing.Point(17, 116);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(82, 20);
            this.publisherLabel.TabIndex = 9;
            this.publisherLabel.Text = "Publisher: ";
            // 
            // rentedLabel
            // 
            this.rentedLabel.AutoSize = true;
            this.rentedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedLabel.Location = new System.Drawing.Point(17, 136);
            this.rentedLabel.Name = "rentedLabel";
            this.rentedLabel.Size = new System.Drawing.Size(70, 20);
            this.rentedLabel.TabIndex = 10;
            this.rentedLabel.Text = "Rented: ";
            // 
            // copiesColorIndicator
            // 
            this.copiesColorIndicator.Location = new System.Drawing.Point(259, 141);
            this.copiesColorIndicator.Name = "copiesColorIndicator";
            this.copiesColorIndicator.ReadOnly = true;
            this.copiesColorIndicator.Size = new System.Drawing.Size(20, 20);
            this.copiesColorIndicator.TabIndex = 11;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(141, 168);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 203);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.copiesColorIndicator);
            this.Controls.Add(this.rentedLabel);
            this.Controls.Add(this.publisherLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.numberOfPagesLabel);
            this.Controls.Add(this.bookGenre);
            this.Controls.Add(this.bookName);
            this.Name = "BookDetails";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox bookGenre;
        private System.Windows.Forms.Label numberOfPagesLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label publisherLabel;
        private System.Windows.Forms.Label rentedLabel;
        private System.Windows.Forms.TextBox copiesColorIndicator;
        private System.Windows.Forms.Button backButton;
    }
}