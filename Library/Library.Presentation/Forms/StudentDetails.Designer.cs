﻿namespace Library.Presentation.Forms
{
    partial class StudentDetails
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
            this.studentFullName = new System.Windows.Forms.TextBox();
            this.studentClass = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.loansListBox = new System.Windows.Forms.ListBox();
            this.studentLoans = new System.Windows.Forms.Label();
            this.currentLoanLabel = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.newLoanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentFullName
            // 
            this.studentFullName.BackColor = System.Drawing.SystemColors.Menu;
            this.studentFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentFullName.Location = new System.Drawing.Point(40, 22);
            this.studentFullName.Name = "studentFullName";
            this.studentFullName.ReadOnly = true;
            this.studentFullName.Size = new System.Drawing.Size(290, 24);
            this.studentFullName.TabIndex = 4;
            this.studentFullName.Text = "Placeholder";
            this.studentFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentClass
            // 
            this.studentClass.BackColor = System.Drawing.SystemColors.Menu;
            this.studentClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentClass.Location = new System.Drawing.Point(40, 46);
            this.studentClass.Name = "studentClass";
            this.studentClass.ReadOnly = true;
            this.studentClass.Size = new System.Drawing.Size(290, 17);
            this.studentClass.TabIndex = 5;
            this.studentClass.Text = "Placeholder";
            this.studentClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdateLabel.Location = new System.Drawing.Point(36, 82);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(82, 20);
            this.birthdateLabel.TabIndex = 6;
            this.birthdateLabel.Text = "Birthdate: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(36, 102);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(71, 20);
            this.genderLabel.TabIndex = 7;
            this.genderLabel.Text = "Gender: ";
            // 
            // loansListBox
            // 
            this.loansListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loansListBox.FormattingEnabled = true;
            this.loansListBox.ItemHeight = 20;
            this.loansListBox.Location = new System.Drawing.Point(40, 148);
            this.loansListBox.Name = "loansListBox";
            this.loansListBox.Size = new System.Drawing.Size(290, 184);
            this.loansListBox.TabIndex = 10;
            // 
            // studentLoans
            // 
            this.studentLoans.AutoSize = true;
            this.studentLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLoans.Location = new System.Drawing.Point(37, 130);
            this.studentLoans.Name = "studentLoans";
            this.studentLoans.Size = new System.Drawing.Size(105, 15);
            this.studentLoans.TabIndex = 11;
            this.studentLoans.Text = "Previous Loans";
            // 
            // currentLoanLabel
            // 
            this.currentLoanLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.currentLoanLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentLoanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLoanLabel.Location = new System.Drawing.Point(40, 345);
            this.currentLoanLabel.Name = "currentLoanLabel";
            this.currentLoanLabel.ReadOnly = true;
            this.currentLoanLabel.Size = new System.Drawing.Size(290, 17);
            this.currentLoanLabel.TabIndex = 14;
            this.currentLoanLabel.Text = "Current loan: ";
            this.currentLoanLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(92, 377);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(83, 31);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.Return);
            // 
            // newLoanButton
            // 
            this.newLoanButton.Location = new System.Drawing.Point(181, 377);
            this.newLoanButton.Name = "newLoanButton";
            this.newLoanButton.Size = new System.Drawing.Size(83, 31);
            this.newLoanButton.TabIndex = 17;
            this.newLoanButton.Text = "New loan";
            this.newLoanButton.UseVisualStyleBackColor = true;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 436);
            this.Controls.Add(this.newLoanButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.currentLoanLabel);
            this.Controls.Add(this.studentLoans);
            this.Controls.Add(this.loansListBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.studentClass);
            this.Controls.Add(this.studentFullName);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentFullName;
        private System.Windows.Forms.TextBox studentClass;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ListBox loansListBox;
        private System.Windows.Forms.Label studentLoans;
        private System.Windows.Forms.TextBox currentLoanLabel;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button newLoanButton;
    }
}