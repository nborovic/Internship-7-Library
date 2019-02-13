namespace Library.Presentation.Forms
{
    partial class MenuMain
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
            this.entitiesListBox = new System.Windows.Forms.ListBox();
            this.authorsButton = new System.Windows.Forms.Button();
            this.publishersButton = new System.Windows.Forms.Button();
            this.studentsButton = new System.Windows.Forms.Button();
            this.booksButton = new System.Windows.Forms.Button();
            this.loansButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entitiesListBox
            // 
            this.entitiesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entitiesListBox.FormattingEnabled = true;
            this.entitiesListBox.ItemHeight = 20;
            this.entitiesListBox.Location = new System.Drawing.Point(38, 67);
            this.entitiesListBox.Name = "entitiesListBox";
            this.entitiesListBox.Size = new System.Drawing.Size(473, 224);
            this.entitiesListBox.TabIndex = 0;
            // 
            // authorsButton
            // 
            this.authorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsButton.Location = new System.Drawing.Point(38, 23);
            this.authorsButton.Name = "authorsButton";
            this.authorsButton.Size = new System.Drawing.Size(88, 38);
            this.authorsButton.TabIndex = 1;
            this.authorsButton.Text = "Authors";
            this.authorsButton.UseVisualStyleBackColor = true;
            this.authorsButton.Click += new System.EventHandler(this.AuthorsRefresh);
            // 
            // publishersButton
            // 
            this.publishersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishersButton.Location = new System.Drawing.Point(132, 23);
            this.publishersButton.Name = "publishersButton";
            this.publishersButton.Size = new System.Drawing.Size(97, 38);
            this.publishersButton.TabIndex = 2;
            this.publishersButton.Text = "Publishers";
            this.publishersButton.UseVisualStyleBackColor = true;
            this.publishersButton.Click += new System.EventHandler(this.PublishersRefresh);
            // 
            // studentsButton
            // 
            this.studentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsButton.Location = new System.Drawing.Point(235, 23);
            this.studentsButton.Name = "studentsButton";
            this.studentsButton.Size = new System.Drawing.Size(88, 38);
            this.studentsButton.TabIndex = 3;
            this.studentsButton.Text = "Students";
            this.studentsButton.UseVisualStyleBackColor = true;
            this.studentsButton.Click += new System.EventHandler(this.StudentsRefresh);
            // 
            // booksButton
            // 
            this.booksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksButton.Location = new System.Drawing.Point(329, 23);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(88, 38);
            this.booksButton.TabIndex = 4;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.BooksRefresh);
            // 
            // loansButton
            // 
            this.loansButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loansButton.Location = new System.Drawing.Point(423, 23);
            this.loansButton.Name = "loansButton";
            this.loansButton.Size = new System.Drawing.Size(88, 38);
            this.loansButton.TabIndex = 5;
            this.loansButton.Text = "Loans";
            this.loansButton.UseVisualStyleBackColor = true;
            this.loansButton.Click += new System.EventHandler(this.LoansRefresh);
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(38, 297);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(88, 38);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.Create);
            // 
            // detailsButton
            // 
            this.detailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.Location = new System.Drawing.Point(164, 297);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(88, 38);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Edit";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.Edit);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(287, 297);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 38);
            this.button9.TabIndex = 8;
            this.button9.Text = "Details";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Details);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(414, 297);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 38);
            this.button10.TabIndex = 9;
            this.button10.Text = "Remove";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Remove);
            // 
            // MenuMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 352);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.loansButton);
            this.Controls.Add(this.booksButton);
            this.Controls.Add(this.studentsButton);
            this.Controls.Add(this.publishersButton);
            this.Controls.Add(this.authorsButton);
            this.Controls.Add(this.entitiesListBox);
            this.Name = "MenuMain";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox entitiesListBox;
        private System.Windows.Forms.Button authorsButton;
        private System.Windows.Forms.Button publishersButton;
        private System.Windows.Forms.Button studentsButton;
        private System.Windows.Forms.Button booksButton;
        private System.Windows.Forms.Button loansButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}