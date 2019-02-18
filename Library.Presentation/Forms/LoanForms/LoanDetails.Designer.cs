namespace Library.Presentation.Forms.LoanForms
{
    partial class LoanDetails
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
            this.studentName = new System.Windows.Forms.TextBox();
            this.bookName = new System.Windows.Forms.TextBox();
            this.returnDateLabel = new System.Windows.Forms.Label();
            this.pickupDateLabel = new System.Windows.Forms.Label();
            this.returnDeadlineLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.BackColor = System.Drawing.SystemColors.Menu;
            this.studentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentName.Location = new System.Drawing.Point(12, 12);
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            this.studentName.Size = new System.Drawing.Size(290, 24);
            this.studentName.TabIndex = 6;
            this.studentName.Text = "Placeholder";
            this.studentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookName
            // 
            this.bookName.BackColor = System.Drawing.SystemColors.Menu;
            this.bookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookName.Location = new System.Drawing.Point(12, 34);
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Size = new System.Drawing.Size(290, 17);
            this.bookName.TabIndex = 7;
            this.bookName.Text = "Placeholder";
            this.bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // returnDateLabel
            // 
            this.returnDateLabel.AutoSize = true;
            this.returnDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLabel.Location = new System.Drawing.Point(8, 114);
            this.returnDateLabel.Name = "returnDateLabel";
            this.returnDateLabel.Size = new System.Drawing.Size(102, 20);
            this.returnDateLabel.TabIndex = 8;
            this.returnDateLabel.Text = "Return date: ";
            // 
            // pickupDateLabel
            // 
            this.pickupDateLabel.AutoSize = true;
            this.pickupDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupDateLabel.Location = new System.Drawing.Point(8, 75);
            this.pickupDateLabel.Name = "pickupDateLabel";
            this.pickupDateLabel.Size = new System.Drawing.Size(100, 20);
            this.pickupDateLabel.TabIndex = 9;
            this.pickupDateLabel.Text = "Pickup date: ";
            // 
            // returnDeadlineLabel
            // 
            this.returnDeadlineLabel.AutoSize = true;
            this.returnDeadlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDeadlineLabel.Location = new System.Drawing.Point(8, 95);
            this.returnDeadlineLabel.Name = "returnDeadlineLabel";
            this.returnDeadlineLabel.Size = new System.Drawing.Size(130, 20);
            this.returnDeadlineLabel.TabIndex = 10;
            this.returnDeadlineLabel.Text = "Return deadline: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(126, 143);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // LoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 177);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.returnDeadlineLabel);
            this.Controls.Add(this.pickupDateLabel);
            this.Controls.Add(this.returnDateLabel);
            this.Controls.Add(this.bookName);
            this.Controls.Add(this.studentName);
            this.Name = "LoanDetails";
            this.Text = "LoanDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.Label returnDateLabel;
        private System.Windows.Forms.Label pickupDateLabel;
        private System.Windows.Forms.Label returnDeadlineLabel;
        private System.Windows.Forms.Button backButton;
    }
}