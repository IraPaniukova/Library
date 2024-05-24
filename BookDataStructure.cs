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
        public List<Book> GetBookByCategory(string category)
        { 
             return booksData.books.Where(b => b.Category.Equals(category)).ToList();         
        }
        public List<Book> GetComputerScience()
        {
            return GetBookByCategory(Config.Categories[0]);
        }
        public List<Book> GetNetworking()
        {
            return GetBookByCategory(Config.Categories[1]);
        }
        public List<Book> GetMathematics()
        {
            return GetBookByCategory(Config.Categories[2]);
        }
        public List<Book> GetSoftwareDevelopment()
        {
            return GetBookByCategory(Config.Categories[3]);
        }
    }
}
