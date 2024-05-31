using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            NoteTextBox.Visible = false;    
        }

        private void addAuthorButtton_Click(object sender, EventArgs e)
        {
            string author = authorTextBox.Text;
            if (!string.IsNullOrEmpty(authorTextBox.Text))
            {
                string properAuthor = new CultureInfo("en-US", false).TextInfo.ToTitleCase(author.ToLower()).Trim();
                Authors.Add(properAuthor);
                authorsListBox.Items.Add(properAuthor);
                authorsListBox.BackColor = SystemColors.InactiveCaption;
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
                if (authorsListBox.Items.Count == 0)
                {
                    authorsListBox.BackColor = Color.LightPink;
                }
                await Alert("CAN NOT ADD! SOME FIELDS ARE EMPTY!");
                //   MessageBox.Show("Some fields are empty");                      
            }
            else
            {
                if (Book.BookByIsbnExists(isbnTextBox.Text))
                { MessageBox.Show("Such ISBN already exists"); }
                else
                {

                    int year = 0;
                    if (int.TryParse(yearTextBox.Text, out _))
                    {
                        year = int.Parse(yearTextBox.Text);
                        string isbn = isbnTextBox.Text.ToUpper().Trim();
                        string bookAuthors = string.Join(":", Authors);
                        string bookName = new CultureInfo("en-US", false).TextInfo.ToTitleCase(bookNameTextBox.Text.ToLower()).Trim();
                        string publisher = new CultureInfo("en-US", false).TextInfo.ToTitleCase(publisherTextBox.Text.ToLower()).Trim();
                        string category = new CultureInfo("en-US", false).TextInfo.ToTitleCase(categoryTextBox.Text.ToLower()).Trim();
                        string bookDescription = isbn + "," + bookAuthors + "," + bookName + "," + publisher + "," + year + "," + category;
                        Book.WriteBookToFile(bookDescription);
                        isbnTextBox.Clear();
                        bookNameTextBox.Clear();
                        authorsListBox.Items.Clear();
                        authorTextBox.Clear();
                        publisherTextBox.Clear();
                        yearTextBox.Clear();
                        categoryTextBox.Clear();
                        Authors.Clear();

                        await Alert("THE BOOK IS SAVED");
                    }
                    else { MessageBox.Show("You can add only digits in the year field"); }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            authorsListBox.Items.Clear();
            Authors.Clear();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void findBookButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(isbnTextBox.Text))
            {
                MessageBox.Show("Add ISBN number to search");
            }
            else
            {
                if (!Book.BookByIsbnExists(isbnTextBox.Text))
                { MessageBox.Show("No such ISBN"); }
                else
                {   Book found = Book.FindBookByIsbn(isbnTextBox.Text);               
                    bookNameTextBox.Text = found.BookName ;
                    authorsListBox.Items.Clear();
                    List<string> authorList = found.Authors.Split(':').ToList();
                    foreach(string item in authorList )
                    {
                        authorsListBox.Items.Add(item);
                    }
                    publisherTextBox.Text = found.Publisher;
                    yearTextBox.Text = found.Year + "";
                    categoryTextBox.Text = found.Category;
                    bookNameTextBox.ReadOnly = true;
                    authorTextBox.ReadOnly = true;
                    publisherTextBox.ReadOnly = true;
                    yearTextBox.ReadOnly = true;
                    categoryTextBox.ReadOnly = true;
                    NoteTextBox.Visible = true;
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            isbnTextBox.Clear();
            bookNameTextBox.Clear();
            authorsListBox.Items.Clear();
            authorTextBox.Clear();
            publisherTextBox.Clear();
            yearTextBox.Clear();
            categoryTextBox.Clear();
            Authors.Clear();
            bookNameTextBox.ReadOnly = false;
            authorTextBox.ReadOnly = false;
            publisherTextBox.ReadOnly = false;
            yearTextBox.ReadOnly = false;
            categoryTextBox.ReadOnly = false;
            NoteTextBox.Visible = false;
        }
    }
}
