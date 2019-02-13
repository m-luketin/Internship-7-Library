namespace Internship_7_Library.Forms
{
    partial class AddBorrow
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
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.BorrowDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BookComboBox
            // 
            this.BookComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(58, 96);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(229, 24);
            this.BookComboBox.TabIndex = 0;
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(58, 36);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(229, 24);
            this.StudentComboBox.TabIndex = 1;
            // 
            // BorrowDatePicker
            // 
            this.BorrowDatePicker.Location = new System.Drawing.Point(58, 154);
            this.BorrowDatePicker.Name = "BorrowDatePicker";
            this.BorrowDatePicker.Size = new System.Drawing.Size(229, 22);
            this.BorrowDatePicker.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(114, 213);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(115, 68);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 327);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BorrowDatePicker);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.BookComboBox);
            this.Name = "AddBorrow";
            this.Text = "AddBorrow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.DateTimePicker BorrowDatePicker;
        private System.Windows.Forms.Button SaveButton;
    }
}