﻿using System;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
            _publishers = new PublisherRepository();
        }

        private readonly PublisherRepository _publishers;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var flag = _publishers.CreatePublisher(PublisherNameBox.Text);

            if (flag)
                Close();
            else
            {
                var errorMessage = new ErrorMessage();
                errorMessage.Show();
            }
        }
    }
}
