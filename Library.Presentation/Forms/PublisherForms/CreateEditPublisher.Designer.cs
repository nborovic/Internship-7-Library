﻿namespace Library.Presentation.Forms.PublisherForms
{
    partial class CreateEditPublisher
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
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // createEditButton
            // 
            this.createEditButton.Location = new System.Drawing.Point(75, 60);
            this.createEditButton.Name = "createEditButton";
            this.createEditButton.Size = new System.Drawing.Size(77, 34);
            this.createEditButton.TabIndex = 6;
            this.createEditButton.Text = "Create";
            this.createEditButton.UseVisualStyleBackColor = true;
            this.createEditButton.Click += new System.EventHandler(this.CreateEdit);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(26, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(173, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 66);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(54, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back);
            // 
            // CreateEditPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 106);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createEditButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CreateEditPublisher";
            this.Text = "Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createEditButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button backButton;
    }
}