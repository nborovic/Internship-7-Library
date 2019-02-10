namespace Library.Presentation.Forms
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
            this.studentBirthdate = new System.Windows.Forms.TextBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.loansListBox = new System.Windows.Forms.ListBox();
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
            // studentBirthdate
            // 
            this.studentBirthdate.BackColor = System.Drawing.SystemColors.Menu;
            this.studentBirthdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentBirthdate.Location = new System.Drawing.Point(40, 46);
            this.studentBirthdate.Name = "studentBirthdate";
            this.studentBirthdate.ReadOnly = true;
            this.studentBirthdate.Size = new System.Drawing.Size(290, 17);
            this.studentBirthdate.TabIndex = 5;
            this.studentBirthdate.Text = "Placeholder";
            this.studentBirthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(36, 82);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(56, 20);
            this.classLabel.TabIndex = 6;
            this.classLabel.Text = "Class: ";
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
            this.loansListBox.Location = new System.Drawing.Point(40, 136);
            this.loansListBox.Name = "loansListBox";
            this.loansListBox.Size = new System.Drawing.Size(290, 224);
            this.loansListBox.TabIndex = 8;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 391);
            this.Controls.Add(this.loansListBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.studentBirthdate);
            this.Controls.Add(this.studentFullName);
            this.Name = "StudentDetails";
            this.Text = "StudentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentFullName;
        private System.Windows.Forms.TextBox studentBirthdate;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ListBox loansListBox;
    }
}