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
            this.SuspendLayout();
            // 
            // PublisherEdit
            // 
            this.PublisherEdit.Location = new System.Drawing.Point(13, 12);
            this.PublisherEdit.Name = "PublisherEdit";
            this.PublisherEdit.Size = new System.Drawing.Size(212, 131);
            this.PublisherEdit.TabIndex = 0;
            this.PublisherEdit.Text = "Publishers";
            this.PublisherEdit.UseVisualStyleBackColor = true;
            this.PublisherEdit.Click += new System.EventHandler(this.PublisherEdit_Click);
            // 
            // AuthorEdit
            // 
            this.AuthorEdit.Location = new System.Drawing.Point(449, 12);
            this.AuthorEdit.Name = "AuthorEdit";
            this.AuthorEdit.Size = new System.Drawing.Size(212, 131);
            this.AuthorEdit.TabIndex = 1;
            this.AuthorEdit.Text = "Authors";
            this.AuthorEdit.UseVisualStyleBackColor = true;
            this.AuthorEdit.Click += new System.EventHandler(this.AuthorEdit_Click);
            // 
            // BookEdit
            // 
            this.BookEdit.Location = new System.Drawing.Point(231, 12);
            this.BookEdit.Name = "BookEdit";
            this.BookEdit.Size = new System.Drawing.Size(212, 131);
            this.BookEdit.TabIndex = 2;
            this.BookEdit.Text = "Books";
            this.BookEdit.UseVisualStyleBackColor = true;
            this.BookEdit.Click += new System.EventHandler(this.BookEdit_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.BookEdit);
            this.Controls.Add(this.AuthorEdit);
            this.Controls.Add(this.PublisherEdit);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PublisherEdit;
        private System.Windows.Forms.Button AuthorEdit;
        private System.Windows.Forms.Button BookEdit;
    }
}