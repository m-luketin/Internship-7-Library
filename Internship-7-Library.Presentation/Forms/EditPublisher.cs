using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Internship_7_Library.Domain.Repositories;
using Internship_7_Library.Data.Entities.Models;

namespace Internship_7_Library.Forms
{
    public partial class EditPublisher : Form
    {
        public EditPublisher(string publisherName, PublisherRepository publisherRepo)
        {
            InitializeComponent();
            _publisherName = publisherName;
            _publishers = publisherRepo;
            PublisherNameBox.Text = publisherName;
        }

        private readonly string _publisherName;
        private readonly PublisherRepository _publishers;
       
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _publishers.UpdatePublisher(_publisherName, PublisherNameBox.Text);
            Close();
        }

        
    }
}
