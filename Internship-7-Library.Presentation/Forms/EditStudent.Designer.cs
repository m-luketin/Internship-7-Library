﻿namespace Internship_7_Library.Forms
{
    partial class EditStudent
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.BirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.GradeComboBox = new System.Windows.Forms.ComboBox();
            this.SexComboBox = new System.Windows.Forms.ComboBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(96, 273);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 61);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.Location = new System.Drawing.Point(111, 126);
            this.BirthDatePicker.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.Size = new System.Drawing.Size(200, 22);
            this.BirthDatePicker.TabIndex = 10;
            // 
            // GradeComboBox
            // 
            this.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeComboBox.FormattingEnabled = true;
            this.GradeComboBox.Location = new System.Drawing.Point(70, 224);
            this.GradeComboBox.Name = "GradeComboBox";
            this.GradeComboBox.Size = new System.Drawing.Size(241, 24);
            this.GradeComboBox.TabIndex = 9;
            // 
            // SexComboBox
            // 
            this.SexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexComboBox.FormattingEnabled = true;
            this.SexComboBox.Location = new System.Drawing.Point(53, 174);
            this.SexComboBox.Name = "SexComboBox";
            this.SexComboBox.Size = new System.Drawing.Size(258, 24);
            this.SexComboBox.TabIndex = 8;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(96, 76);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(215, 22);
            this.LastNameBox.TabIndex = 7;
            this.LastNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameBox_KeyPress);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(96, 26);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(215, 22);
            this.FirstNameBox.TabIndex = 6;
            this.FirstNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date of birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "First name:";
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(323, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.GradeComboBox);
            this.Controls.Add(this.SexComboBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox GradeComboBox;
        private System.Windows.Forms.ComboBox SexComboBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}