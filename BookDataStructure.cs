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
     //   public Queue<Book> FilteredQueue;

        public BookDataStructure()
        {
            booksData.ReadBooksFromFile();

        }
        public Queue<Book> FilteredQueue() {  
                return new Queue<Book>(booksData.books.Where(b => 
                (b.Category.Equals(Config.Categories[0]) || 
                 b.Category.Equals(Config.Categories[1]) ||
                 b.Category.Equals(Config.Categories[2]) ||
                 b.Category.Equals(Config.Categories[3]))
                && b.Year > 1990));
            }
    }
}
