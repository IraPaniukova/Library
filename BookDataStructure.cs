using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookDataStructure
    {
        private ReadDataFile booksData = new ReadDataFile();
        public BookDataStructure()
        {
            booksData.ReadBooksFromFile(); 
        }
        public Queue<Book> GetBookByCategory(string category)
        {
            return new Queue<Book>(booksData.books.Where(b => b.Category.Equals(category)&& b.Year>1990));
        }
        //Option 2 that does the same, but uses Enqueue:
        //public Queue<Book> GetBookByCategory(string category)
        //{
        //    Queue<Book> result = new Queue<Book>();
        //    foreach (Book book in booksData.books)
        //    {
        //        if (book.Category.Equals(category) && book.Year>1990)
        //        {
        //            result.Enqueue(book);
        //        }
        //    }
        //    return result;
        //}
       
        public Queue<Book> GetComputerScience()
        {
            return GetBookByCategory(Config.Categories[0]);
        }
        public Queue<Book> GetNetworking()
        {
            return GetBookByCategory(Config.Categories[1]);
        }
        public Queue<Book> GetMathematics()
        {
            return GetBookByCategory(Config.Categories[2]);
        }
        public Queue<Book> GetSoftwareDevelopment()
        {
            return GetBookByCategory(Config.Categories[3]);
        }
    }
}
