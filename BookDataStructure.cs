using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //--Because you told that we need to add the book with the category "Computer Networks", 
        //I am adjusting the list and replacing it with a correct name of the category
        public void AdjustCategories()
        {
            foreach (var book in booksData.books)
            {
                book.Category = Config.ComputerScience.Contains(book.Category) ? Config.Categories[0] :
                                Config.Networking.Contains(book.Category) ? Config.Categories[1] :
                                Config.Mathematics.Contains(book.Category) ? Config.Categories[2] :
                                Config.SoftwareDevelopment.Contains(book.Category) ? Config.Categories[3] :
                                book.Category; 
            }
        }
        //---------------------------

        public Queue<Book> GetFilteredQueue()
        {
            AdjustCategories();
            return new Queue<Book>(booksData.books.Where(b =>
            Config.Categories.Contains(b.Category)
            && b.Year > 1990));
            //published after 1990 -  it means means that 1990 is not included
        }
    }
}
