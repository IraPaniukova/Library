using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    internal class Book
    {
        public string Isbn { get; set; }
        public string Authors { get; set; }
        public string BookName { get; set; }     
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {          
            return Isbn + "," +Authors+","+ BookName + "," + Publisher+","+Year+","+Category ;
        }
        //TASK: create a class Book to store and manage book information stored in the file. 
        public static void WriteBookToFile(string bookDescription)
        {
            string filePath = "C:\\Users\\I\\source\\repos\\Library\\bin\\Debug\\data.txt";
            List<string> Books = File.ReadAllLines(filePath).ToList();
            Books.Add(bookDescription);
            File.WriteAllLines(filePath, Books);
        }
        //public bool IsValid()
        //{
        //    return Year > 1990 && "ABCD".Contains(Category);
        //}
    }
}
