namespace Internship_7_Library.Forms
{
    partial class Borrows
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
            this.AddBorrowButton = new System.Windows.Forms.Button();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBorrowButton
            // 
            this.AddBorrowButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBorrowButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBorrowButton.Location = new System.Drawing.Point(12, 127);
            this.AddBorrowButton.Name = "AddBorrowButton";
            this.AddBorrowButton.Size = new System.Drawing.Size(161, 82);
            this.AddBorrowButton.TabIndex = 0;
            this.AddBorrowButton.Text = "New borrow";
            this.AddBorrowButton.UseVisualStyleBackColor = false;
            this.AddBorrowButton.Click += new System.EventHandler(this.AddBorrowButton_Click);
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReturnBookButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ReturnBookButton.Location = new System.Drawing.Point(12, 12);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(161, 82);
            this.ReturnBookButton.TabIndex = 1;
            this.ReturnBookButton.Text = "Return book";
            this.ReturnBookButton.UseVisualStyleBackColor = false;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Internship_7_Library.Properties.Resources.kissclipart_book_clipart_book_computer_icons_reading_1eb6afe82712eba4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 197);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Borrows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(388, 223);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.AddBorrowButton);
            this.Name = "Borrows";
            this.Text = "Borrows";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBorrowButton;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}