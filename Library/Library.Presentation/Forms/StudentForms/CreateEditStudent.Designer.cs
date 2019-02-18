namespace Library.Presentation.Forms.StudentForms
{
    partial class CreateEditStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createEditButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.genderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "First name";
            // 
            // createEditButton
            // 
            this.createEditButton.Location = new System.Drawing.Point(75, 209);
            this.createEditButton.Name = "createEditButton";
            this.createEditButton.Size = new System.Drawing.Size(92, 33);
            this.createEditButton.TabIndex = 8;
            this.createEditButton.Text = "Create";
            this.createEditButton.UseVisualStyleBackColor = true;
            this.createEditButton.Click += new System.EventHandler(this.CreateEdit);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(31, 68);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(31, 31);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(188, 20);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(31, 106);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(188, 21);
            this.classComboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Class";
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Location = new System.Drawing.Point(31, 148);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(188, 20);
            this.birthdayDatePicker.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Birthdate";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(39, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 16;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(93, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 17;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.maleRadioButton);
            this.genderPanel.Controls.Add(this.femaleRadioButton);
            this.genderPanel.Location = new System.Drawing.Point(32, 174);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(188, 23);
            this.genderPanel.TabIndex = 18;
            // 
            // CreateEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 257);
            this.Controls.Add(this.genderPanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthdayDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createEditButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "CreateEditStudent";
            this.Text = "Student";
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEditButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Panel genderPanel;
    }
}