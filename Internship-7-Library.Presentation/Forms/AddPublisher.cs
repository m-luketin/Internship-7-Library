using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Data.Entities.Models;
using Internship_7_Library.Domain.Repositories;

namespace Internship_7_Library.Forms
{
    public partial class AddPublisher : Form
    {
        public AddPublisher(PublisherRepository publisherRepo)
        {
            InitializeComponent();
            publishers = publisherRepo;
        }

        private PublisherRepository publishers;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var flag = publishers.CreatePublisher(PublisherNameBox.Text);

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
