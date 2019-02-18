namespace Library.Presentation.Forms.LoanForms
{
    partial class CreateEditLoan
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
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchEntity = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.searchCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // studentsListBox
            // 
            this.studentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 20;
            this.studentsListBox.Location = new System.Drawing.Point(22, 80);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(250, 144);
            this.studentsListBox.TabIndex = 0;
            // 
            // booksListBox
            // 
            this.booksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(22, 250);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(250, 144);
            this.booksListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Books";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(94, 414);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(95, 37);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateEdit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Search";
            // 
            // searchEntity
            // 
            this.searchEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.searchEntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEntity.Location = new System.Drawing.Point(22, 34);
            this.searchEntity.Name = "searchEntity";
            this.searchEntity.Size = new System.Drawing.Size(153, 22);
            this.searchEntity.TabIndex = 28;
            this.searchEntity.TextChanged += new System.EventHandler(this.SearchStudent);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 421);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // searchCheckBox
            // 
            this.searchCheckBox.AutoSize = true;
            this.searchCheckBox.Location = new System.Drawing.Point(185, 38);
            this.searchCheckBox.Name = "searchCheckBox";
            this.searchCheckBox.Size = new System.Drawing.Size(87, 17);
            this.searchCheckBox.TabIndex = 31;
            this.searchCheckBox.Text = "Search book";
            this.searchCheckBox.UseVisualStyleBackColor = true;
            this.searchCheckBox.CheckedChanged += new System.EventHandler(this.SearchCheckedChanged);
            // 
            // CreateEditLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 464);
            this.Controls.Add(this.searchCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchEntity);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.booksListBox);
            this.Controls.Add(this.studentsListBox);
            this.Name = "CreateEditLoan";
            this.Text = "CreateEditLoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchEntity;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox searchCheckBox;
    }
}