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
        private Queue<Book> bookQueueFiltered;
        public BookDataStructure()
        {
            booksData.ReadBooksFromFile();
            bookQueueFiltered = new Queue<Book>(booksData.books.Where(b =>
            Config.Categories.Contains(b.Category)
            && b.Year > 1990));
        }
        public Queue<Book> GetFilteredQueue()
        {
            return bookQueueFiltered;
        }
    }
}
