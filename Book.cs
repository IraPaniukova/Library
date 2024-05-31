using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library
{
    internal class Book
    {
        public string Isbn { get; set; }
        public string Authors { get; set; }
        public string BookName { get; set; }     
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {          
            return Isbn + "," +Authors+","+ BookName + "," + Publisher+","+Year+","+Category ;
        }

        //TASK: create a class Book to store and manage book information stored in the file.
        //That is why I have here following methods to store and manage books:
        public static void WriteBookToFile(string bookDescription)
        {
            string filePath = "C:\\Users\\I\\source\\repos\\Library\\bin\\Debug\\data.txt";
            List<string> Books = File.ReadAllLines(filePath).ToList();
            Books.Add(bookDescription);
            File.WriteAllLines(filePath, Books);
        }
        public static bool BookByIsbnExists(string isbn)
        {
            ReadDataFile data = new ReadDataFile();
            foreach (var book in data.ReadBooksFromFile())
            {
                if (isbn == book.Isbn)
                    return true;
            }
            return false;
        }
        public static Book FindBookByIsbn(string isbn)
        {
            ReadDataFile data = new ReadDataFile();
            foreach (var book in data.ReadBooksFromFile())
            {
                if (isbn == book.Isbn)
                    return book;
            }
            return null;
        }

        public static void DeleteBookFromFile(string isbn) //just to show usage of a Dictionary
        {   Dictionary<string, Book> books = new Dictionary<string, Book>();
            ReadDataFile data = new ReadDataFile();       
            foreach (var book in data.ReadBooksFromFile())
            {
                  books.Add(book.Isbn, book);  // Adding book to the Dictionary using ISBN as the key
            }
            Console.WriteLine("boo");
            if (books.ContainsKey(isbn))
            {
                books.Remove(isbn);
                File.WriteAllText("data.txt", string.Empty);
                using (StreamWriter writer = new StreamWriter("data.txt", true))
                {
                    foreach (var book in books.Values)
                    {
                        writer.WriteLine($"{book.Isbn},{book.Authors},{book.BookName},{book.Publisher},{book.Year},{book.Category}");
                    }
                }
            }
        }
      

    }
}
