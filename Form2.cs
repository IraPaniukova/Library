using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            ReadDataFile data = new ReadDataFile();
            allBooksListBox.DataSource=data.ReadBooksFromFile();
            BookDataStructure filteredData = new BookDataStructure();
            filteredLstBox.DataSource = filteredData.GetFilteredQueue().ToList();
        }

        private void viewCategoriesButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData data = new ProcessBooksData();
            computerScienceListBox.DataSource = data.GetComputerScience().ToList();
            networkListBox.DataSource=data.GetNetworking().ToList();
            mathListBox.DataSource=data.GetMathematics().ToList();
            softwareDevelopmentListBox.DataSource=data.GetSoftwareDevelopment().ToList();
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void viewCompSciButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData data = new ProcessBooksData();
            if (data.GetComputerScience().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            computerScienceListBox.DataSource = data.GetComputerScience().ToList();
        }

        private void viewNetworkButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData data = new ProcessBooksData();
            if (data.GetNetworking().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            networkListBox.DataSource = data.GetNetworking().ToList();
        }

        private void viewMathButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData data = new ProcessBooksData();
            if (data.GetMathematics().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            mathListBox.DataSource = data.GetMathematics().ToList();
        }

        private void viewSWdvlpmntButton_Click(object sender, EventArgs e)
        {
            ProcessBooksData data = new ProcessBooksData();
            if (data.GetSoftwareDevelopment().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            softwareDevelopmentListBox.DataSource = data.GetSoftwareDevelopment().ToList();
        }

        private void clearCompSciButton_Click(object sender, EventArgs e)
        {
            computerScienceListBox.DataSource = null;
        }

        private void clearNetworkButton_Click(object sender, EventArgs e)
        {
            networkListBox.DataSource =null;
        }

        private void clearMathButton_Click(object sender, EventArgs e)
        {
            mathListBox.DataSource = null;
        }

        private void clearSWdvlpmntButton_Click(object sender, EventArgs e)
        {
            softwareDevelopmentListBox.DataSource = null;
        }
    }
}
