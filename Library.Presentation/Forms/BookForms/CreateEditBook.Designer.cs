﻿namespace Library.Presentation.Forms.BookForms
{
    partial class CreateEditBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.createEditButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.publishersListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.searchEntity = new System.Windows.Forms.TextBox();
            this.numberOfCopiesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.numberOfPagesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.backButton = new System.Windows.Forms.Button();
            this.searchCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // createEditButton
            // 
            this.createEditButton.Location = new System.Drawing.Point(112, 546);
            this.createEditButton.Name = "createEditButton";
            this.createEditButton.Size = new System.Drawing.Size(96, 40);
            this.createEditButton.TabIndex = 9;
            this.createEditButton.Text = "Create";
            this.createEditButton.UseVisualStyleBackColor = true;
            this.createEditButton.Click += new System.EventHandler(this.CreateEdit);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(33, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(263, 20);
            this.nameTextBox.TabIndex = 8;
            // 
            // authorsListBox
            // 
            this.authorsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 20;
            this.authorsListBox.Location = new System.Drawing.Point(33, 249);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(263, 124);
            this.authorsListBox.TabIndex = 11;
            // 
            // publishersListBox
            // 
            this.publishersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishersListBox.FormattingEnabled = true;
            this.publishersListBox.ItemHeight = 20;
            this.publishersListBox.Location = new System.Drawing.Point(36, 406);
            this.publishersListBox.Name = "publishersListBox";
            this.publishersListBox.Size = new System.Drawing.Size(263, 124);
            this.publishersListBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number of copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Select author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Select publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(84, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search";
            // 
            // searchEntity
            // 
            this.searchEntity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.searchEntity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEntity.Location = new System.Drawing.Point(33, 204);
            this.searchEntity.Name = "searchEntity";
            this.searchEntity.Size = new System.Drawing.Size(153, 22);
            this.searchEntity.TabIndex = 24;
            this.searchEntity.TextChanged += new System.EventHandler(this.SearchAuthor);
            // 
            // numberOfCopiesTextBox
            // 
            this.numberOfCopiesTextBox.Location = new System.Drawing.Point(33, 155);
            this.numberOfCopiesTextBox.Mask = "0000";
            this.numberOfCopiesTextBox.Name = "numberOfCopiesTextBox";
            this.numberOfCopiesTextBox.Size = new System.Drawing.Size(263, 20);
            this.numberOfCopiesTextBox.TabIndex = 26;
            this.numberOfCopiesTextBox.ValidatingType = typeof(int);
            // 
            // numberOfPagesTextBox
            // 
            this.numberOfPagesTextBox.Location = new System.Drawing.Point(33, 114);
            this.numberOfPagesTextBox.Mask = "00000";
            this.numberOfPagesTextBox.Name = "numberOfPagesTextBox";
            this.numberOfPagesTextBox.Size = new System.Drawing.Size(263, 20);
            this.numberOfPagesTextBox.TabIndex = 27;
            this.numberOfPagesTextBox.ValidatingType = typeof(int);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(33, 76);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(263, 21);
            this.genreComboBox.TabIndex = 28;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 555);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 29;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // searchCheckBox
            // 
            this.searchCheckBox.AutoSize = true;
            this.searchCheckBox.Location = new System.Drawing.Point(192, 208);
            this.searchCheckBox.Name = "searchCheckBox";
            this.searchCheckBox.Size = new System.Drawing.Size(105, 17);
            this.searchCheckBox.TabIndex = 30;
            this.searchCheckBox.Text = "Search publisher";
            this.searchCheckBox.UseVisualStyleBackColor = true;
            this.searchCheckBox.CheckedChanged += new System.EventHandler(this.SearchCheckedChanged);
            // 
            // CreateEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 599);
            this.Controls.Add(this.searchCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.numberOfPagesTextBox);
            this.Controls.Add(this.numberOfCopiesTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.searchEntity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.publishersListBox);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createEditButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CreateEditBook";
            this.Text = "Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEditButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.ListBox publishersListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchEntity;
        private System.Windows.Forms.MaskedTextBox numberOfCopiesTextBox;
        private System.Windows.Forms.MaskedTextBox numberOfPagesTextBox;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox searchCheckBox;
    }
}