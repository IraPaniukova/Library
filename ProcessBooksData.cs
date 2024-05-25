using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class ProcessBooksData
    {

        private BookDataStructure booksData = new BookDataStructure();

        public Stack<Book> GetBookByCategory(string category)
        {
            return new Stack<Book>(booksData.FilteredQueue().Where(b => b.Category.Equals(category)));
        }
        
        public Stack<Book> GetComputerScience()
        {
            return GetBookByCategory(Config.Categories[0]);
        }
        public Stack<Book> GetNetworking()
        {
            return GetBookByCategory(Config.Categories[1]);
        }
        public Stack<Book> GetMathematics()
        {
            return GetBookByCategory(Config.Categories[2]);
        }
        public Stack<Book> GetSoftwareDevelopment()
        {
            return GetBookByCategory(Config.Categories[3]);
        }
    }
}
