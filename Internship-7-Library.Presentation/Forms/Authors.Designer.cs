﻿namespace Internship_7_Library.Forms
{
    partial class Authors
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
            this.BookBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AuthorsListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BookBox
            // 
            this.BookBox.FormattingEnabled = true;
            this.BookBox.ItemHeight = 16;
            this.BookBox.Location = new System.Drawing.Point(459, 7);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(158, 404);
            this.BookBox.TabIndex = 9;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(320, 272);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 79);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(320, 67);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 79);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(320, 166);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 79);
            this.EditButton.TabIndex = 6;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AuthorsListBox
            // 
            this.AuthorsListBox.FormattingEnabled = true;
            this.AuthorsListBox.Location = new System.Drawing.Point(133, 7);
            this.AuthorsListBox.Name = "AuthorsListBox";
            this.AuthorsListBox.Size = new System.Drawing.Size(165, 395);
            this.AuthorsListBox.TabIndex = 5;
            this.AuthorsListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AuthorsListBox_ItemCheck);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 418);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AuthorsListBox);
            this.Name = "Authors";
            this.Text = "EditAuthor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BookBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.CheckedListBox AuthorsListBox;
    }
}