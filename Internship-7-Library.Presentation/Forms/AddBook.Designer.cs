namespace Internship_7_Library.Forms
{
    partial class AddBook
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PagesBox = new System.Windows.Forms.TextBox();
            this.NumberOfBooksBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.PublisherComboBox = new System.Windows.Forms.ComboBox();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(30, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(263, 22);
            this.NameBox.TabIndex = 1;
            // 
            // PagesBox
            // 
            this.PagesBox.Location = new System.Drawing.Point(30, 195);
            this.PagesBox.Name = "PagesBox";
            this.PagesBox.Size = new System.Drawing.Size(263, 22);
            this.PagesBox.TabIndex = 3;
            // 
            // NumberOfBooksBox
            // 
            this.NumberOfBooksBox.Location = new System.Drawing.Point(30, 253);
            this.NumberOfBooksBox.Name = "NumberOfBooksBox";
            this.NumberOfBooksBox.Size = new System.Drawing.Size(263, 22);
            this.NumberOfBooksBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(115, 359);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 58);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Location = new System.Drawing.Point(73, 67);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(178, 24);
            this.AuthorComboBox.TabIndex = 6;
            // 
            // PublisherComboBox
            // 
            this.PublisherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PublisherComboBox.FormattingEnabled = true;
            this.PublisherComboBox.Location = new System.Drawing.Point(73, 137);
            this.PublisherComboBox.Name = "PublisherComboBox";
            this.PublisherComboBox.Size = new System.Drawing.Size(178, 24);
            this.PublisherComboBox.TabIndex = 7;
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(74, 303);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(176, 24);
            this.GenreComboBox.TabIndex = 8;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 467);
            this.Controls.Add(this.GenreComboBox);
            this.Controls.Add(this.PublisherComboBox);
            this.Controls.Add(this.AuthorComboBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NumberOfBooksBox);
            this.Controls.Add(this.PagesBox);
            this.Controls.Add(this.NameBox);
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PagesBox;
        private System.Windows.Forms.TextBox NumberOfBooksBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.ComboBox PublisherComboBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
    }
}