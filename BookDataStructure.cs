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
        }

        public Queue<Book> GetFilteredQueue()
        {
            return new Queue<Book>(booksData.books.Where(b =>
            Config.Categories.Contains(b.Category)
            && b.Year > 1990));
        }
    }
}
