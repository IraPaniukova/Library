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
      //  private Queue<Book> bookQueue;
        public BookDataStructure()
        {
            booksData.ReadBooksFromFile();
          //  bookQueue = new Queue<Book>();
        }

        public Queue<Book> GetFilteredQueue()
        {
            return new Queue<Book>(booksData.books.Where(b =>
            Config.Categories.Contains(b.Category)
            && b.Year > 1990));
        }

        //public  Queue<Book> GetBookByCategory(string category)
        //{ 
        //    return new Queue<Book>(booksData.books.Where(b => b.Category.Equals(category)&& b.Year>1990));
        //}
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
    }
}
