namespace Internship_7_Library.Forms
{
    partial class Publishers
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
            this.PublishersListBox = new System.Windows.Forms.CheckedListBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BookBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // PublishersListBox
            // 
            this.PublishersListBox.FormattingEnabled = true;
            this.PublishersListBox.Location = new System.Drawing.Point(21, 22);
            this.PublishersListBox.Name = "PublishersListBox";
            this.PublishersListBox.Size = new System.Drawing.Size(165, 395);
            this.PublishersListBox.TabIndex = 0;
            this.PublishersListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PublishersListBox_ItemCheck);
            this.PublishersListBox.SelectedIndexChanged += new System.EventHandler(this.PublishersListBox_SelectedIndexChanged);
            this.PublishersListBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PublishersListBox_MouseMove);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(208, 181);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(121, 79);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(208, 82);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 79);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(208, 287);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(121, 79);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BookBox
            // 
            this.BookBox.FormattingEnabled = true;
            this.BookBox.ItemHeight = 16;
            this.BookBox.Location = new System.Drawing.Point(347, 22);
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(158, 404);
            this.BookBox.TabIndex = 4;
            // 
            // Publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.PublishersListBox);
            this.Name = "Publishers";
            this.Text = "EditPublishers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PublishersListBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ListBox BookBox;
    }
}