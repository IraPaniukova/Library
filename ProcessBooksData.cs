using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class ProcessBooksData
    {

        //public ProcessBooksData()
        //{
        //    booksData.FilteredQueue(); 
        //}
        private BookDataStructure booksData = new BookDataStructure(); 

        public Queue<Book> GetBookByCategory(string category)
        {
            return new Queue<Book>(booksData.FilteredQueue().Where(b => b.Category.Equals(category)));
        }
        //NEED TO CHANGE TO STACK NOW
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
