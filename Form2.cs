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
        ReadDataFile data = new ReadDataFile();
        BookDataStructure filteredData = new BookDataStructure();
        ProcessBooksData categorisedData = new ProcessBooksData();
        public Form2()
        {
            InitializeComponent();
        }
        private void viewAllButton_Click(object sender, EventArgs e)
        {
            allBooksListBox.DataSource = data.ReadBooksFromFile();
            filteredLstBox.DataSource = filteredData.GetFilteredQueue().ToList();
        }

        private void viewCategoriesButton_Click(object sender, EventArgs e)
        {

            computerScienceListBox.DataSource = categorisedData.GetComputerScience().ToList();
            networkListBox.DataSource = categorisedData.GetNetworking().ToList();
            mathListBox.DataSource = categorisedData.GetMathematics().ToList();
            softwareDevelopmentListBox.DataSource = categorisedData.GetSoftwareDevelopment().ToList();
        }

        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void viewCompSciButton_Click(object sender, EventArgs e)
        {

            if (categorisedData.GetComputerScience().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            computerScienceListBox.DataSource = categorisedData.GetComputerScience().ToList();
        }

        private void viewNetworkButton_Click(object sender, EventArgs e)
        {

            if (categorisedData.GetNetworking().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            networkListBox.DataSource = categorisedData.GetNetworking().ToList();
        }

        private void viewMathButton_Click(object sender, EventArgs e)
        {

            if (categorisedData.GetMathematics().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            mathListBox.DataSource = categorisedData.GetMathematics().ToList();
        }

        private void viewSWdvlpmntButton_Click(object sender, EventArgs e)
        {

            if (categorisedData.GetSoftwareDevelopment().Count == 0)
            {
                MessageBox.Show("There are no books in this category");
            }
            softwareDevelopmentListBox.DataSource = categorisedData.GetSoftwareDevelopment().ToList();
        }

        private void clearCompSciButton_Click(object sender, EventArgs e)
        {
            computerScienceListBox.DataSource = null;
        }

        private void clearNetworkButton_Click(object sender, EventArgs e)
        {
            networkListBox.DataSource = null;
        }

        private void clearMathButton_Click(object sender, EventArgs e)
        {
            mathListBox.DataSource = null;
        }

        private void clearSWdvlpmntButton_Click(object sender, EventArgs e)
        {
            softwareDevelopmentListBox.DataSource = null;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            
            allBooksListBox.DataSource = data.ReadBooksFromFile();
            Form3 f = new Form3(this)
            {
                StartPosition = FormStartPosition.Manual,
                Location = new Point(this.Location.X + 400, this.Location.Y)
            };
            f.ShowDialog();
            this.Hide();   //the simpliest way to create new instances just create a new form
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}