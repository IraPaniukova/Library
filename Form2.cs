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
            ReadDataFile allBooks = new ReadDataFile();
            allBooksListBox.DataSource=allBooks.ReadBooksFromFile();
            BookDataStructure filteredBooks = new BookDataStructure();
            filteredListBox.DataSource = filteredBooks.FilteredQueue().ToList();
        }


        private void addNewBookButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }    

        private void showInPilesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }
    }
}
