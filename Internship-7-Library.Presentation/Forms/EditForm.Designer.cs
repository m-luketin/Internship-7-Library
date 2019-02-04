namespace Internship_7_Library.Forms
{
    partial class EditForm
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
            this.PublisherEdit = new System.Windows.Forms.Button();
            this.AuthorEdit = new System.Windows.Forms.Button();
            this.BookEdit = new System.Windows.Forms.Button();
            this.StudentEdit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PublisherEdit
            // 
            this.PublisherEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PublisherEdit.ForeColor = System.Drawing.SystemColors.Info;
            this.PublisherEdit.Location = new System.Drawing.Point(402, 12);
            this.PublisherEdit.Name = "PublisherEdit";
            this.PublisherEdit.Size = new System.Drawing.Size(212, 131);
            this.PublisherEdit.TabIndex = 0;
            this.PublisherEdit.Text = "Publishers";
            this.PublisherEdit.UseVisualStyleBackColor = false;
            this.PublisherEdit.Click += new System.EventHandler(this.PublisherEdit_Click);
            // 
            // AuthorEdit
            // 
            this.AuthorEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AuthorEdit.ForeColor = System.Drawing.SystemColors.Menu;
            this.AuthorEdit.Location = new System.Drawing.Point(184, 12);
            this.AuthorEdit.Name = "AuthorEdit";
            this.AuthorEdit.Size = new System.Drawing.Size(212, 131);
            this.AuthorEdit.TabIndex = 1;
            this.AuthorEdit.Text = "Authors";
            this.AuthorEdit.UseVisualStyleBackColor = false;
            this.AuthorEdit.Click += new System.EventHandler(this.AuthorEdit_Click);
            // 
            // BookEdit
            // 
            this.BookEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BookEdit.ForeColor = System.Drawing.SystemColors.Info;
            this.BookEdit.Location = new System.Drawing.Point(184, 163);
            this.BookEdit.Name = "BookEdit";
            this.BookEdit.Size = new System.Drawing.Size(212, 131);
            this.BookEdit.TabIndex = 2;
            this.BookEdit.Text = "Books";
            this.BookEdit.UseVisualStyleBackColor = false;
            this.BookEdit.Click += new System.EventHandler(this.BookEdit_Click);
            // 
            // StudentEdit
            // 
            this.StudentEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentEdit.ForeColor = System.Drawing.SystemColors.Info;
            this.StudentEdit.Location = new System.Drawing.Point(402, 163);
            this.StudentEdit.Name = "StudentEdit";
            this.StudentEdit.Size = new System.Drawing.Size(212, 131);
            this.StudentEdit.TabIndex = 3;
            this.StudentEdit.Text = "Students";
            this.StudentEdit.UseVisualStyleBackColor = false;
            this.StudentEdit.Click += new System.EventHandler(this.StudentEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Internship_7_Library.Properties.Resources._253_5121;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(620, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 206);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Internship_7_Library.Properties.Resources.positive_L015_512;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 196);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(779, 296);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StudentEdit);
            this.Controls.Add(this.BookEdit);
            this.Controls.Add(this.AuthorEdit);
            this.Controls.Add(this.PublisherEdit);
            this.Name = "EditForm";
            this.Text = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublisherEdit;
        private System.Windows.Forms.Button AuthorEdit;
        private System.Windows.Forms.Button BookEdit;
        private System.Windows.Forms.Button StudentEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}