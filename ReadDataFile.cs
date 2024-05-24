using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class ReadDataFile
    {
        public List<Book> books= new List<Book>();   
        public List<Book> ReadBooksFromFile()
        {
            StreamReader reader = new StreamReader("data.txt");
            string bookRecord = "";
            while ((bookRecord = reader.ReadLine()) != null)
            {
                string[] bookData = bookRecord.Split(',');
                Book book = new Book();
                book.Isbn = bookData[0];
                book.Authors = bookData[1];
                book.BookName = bookData[2];
                book.Publisher = bookData[3];
                book.Year = int.Parse(bookData[4]);
                book.Category = bookData[5];
                books.Add(book);
            }
            return books;
        }
        
    }
}
