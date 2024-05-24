using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Form1 : Form
    {
        List<string> Authors = new List<string>();
        public Form1()
        {
            InitializeComponent();
            alertTextBox.Visible = false;
        }
        
        private void addAuthorButtton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            if (!string.IsNullOrEmpty(authorTextBox.Text))
            {
                Authors.Add(author);
                authorsListBox.Items.Add(author);
                authorTextBox.Clear();
            }
        }

        private async Task Alert(string message)
        {
            alertTextBox.Visible = true;
            alertTextBox.Text = message;
            await Task.Delay(3000);
            alertTextBox.Visible = false;
        }

        private async void saveBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(isbnTextBox.Text) ||
                authorsListBox.Items.Count == 0 ||
                string.IsNullOrEmpty(bookNameTextBox.Text) ||
                string.IsNullOrEmpty(publisherTextBox.Text) ||
                string.IsNullOrEmpty(yearTextBox.Text) ||
                string.IsNullOrEmpty(categoryTextBox.Text)
                )
            {
                await Alert("CAN NOT ADD! SOME FIELDS ARE EMPTY!");
                //   MessageBox.Show("Some fields are empty");
            }
            else
            {
                string isbn = isbnTextBox.Text;
                string bookAuthors = string.Join(":", Authors);
                string bookName = bookNameTextBox.Text;
                string publisher = publisherTextBox.Text;
                int year = int.Parse(yearTextBox.Text);
                string category = categoryTextBox.Text;
                string bookDescription = isbn + "," + bookAuthors + "," + bookName + "," + publisher + "," + year + "," + category;
                Book.WriteBookToFile(bookDescription);

                isbnTextBox.Clear();
                bookNameTextBox.Clear();
                authorsListBox.Items.Clear();
                authorTextBox.Clear();
                publisherTextBox.Clear();
                yearTextBox.Clear();
                categoryTextBox.Clear();

                await Alert("THE BOOK IS SAVED");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            authorsListBox.Items.Clear();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }
    }
}
