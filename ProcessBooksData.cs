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
        private Stack<Book> ComputerScienceStack;
        private Stack<Book> NetworkStack;
        private Stack<Book> MathStack;
        private Stack<Book> SoftwareDevelopmentStack;
        

        public Stack<Book> GetBookByCategory(string category)
        {
            return new Stack<Book>(booksData.GetFilteredQueue().Where(b => b.Category.Equals(category)));
             
        }
        public ProcessBooksData()
        {
            ComputerScienceStack = GetBookByCategory(Config.Categories[0]);
            NetworkStack = GetBookByCategory(Config.Categories[1]);
            MathStack = GetBookByCategory(Config.Categories[2]);
            SoftwareDevelopmentStack= GetBookByCategory(Config.Categories[3]);
        }
        public Stack<Book> GetComputerScience()
        {
            return ComputerScienceStack;
        }
        public Stack<Book> GetNetworking()
        {
            return NetworkStack;
        }
        public Stack<Book> GetMathematics()
        {
            return MathStack;
        }
        public Stack<Book> GetSoftwareDevelopment()
        {
            return SoftwareDevelopmentStack;
        }
    }
}
