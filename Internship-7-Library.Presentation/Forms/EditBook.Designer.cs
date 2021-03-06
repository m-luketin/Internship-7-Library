﻿namespace Internship_7_Library.Forms
{
    partial class EditBook
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
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NumberOfBooksBox = new System.Windows.Forms.TextBox();
            this.PagesBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(72, 287);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(258, 24);
            this.GenreComboBox.TabIndex = 15;
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(89, 125);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(241, 24);
            this.PublisherComboBox.TabIndex = 14;
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(72, 72);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(258, 24);
            this.AuthorComboBox.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveButton.Location = new System.Drawing.Point(115, 331);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(121, 72);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NumberOfBooksBox
            // 
            this.NumberOfBooksBox.Location = new System.Drawing.Point(140, 238);
            this.NumberOfBooksBox.Name = "NumberOfBooksBox";
            this.NumberOfBooksBox.Size = new System.Drawing.Size(190, 22);
            this.NumberOfBooksBox.TabIndex = 11;
            this.NumberOfBooksBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberOfBooksBox_KeyPress);
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(139, 180);
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(191, 22);
            this.PagesBox.TabIndex = 10;
            this.PagesBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PagesBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(67, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(263, 22);
            this.NameBox.TabIndex = 9;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Number of copies:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number of pages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Publisher:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(347, 418);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.PublisherComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NumberOfBooksBox);
            this.Controls.Add(this.PagesBox);
            this.Controls.Add(this.NameBox);
            this.Name = "EditBook";
            this.Text = "EditBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NumberOfBooksBox;
        private System.Windows.Forms.TextBox PagesBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}