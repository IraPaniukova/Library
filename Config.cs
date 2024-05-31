using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Config
    {
        // The categories can be changed here
        public static List<string> Categories { get; } = new List<string>
        { "Computer Science", "Networking", "Mathematics", "Software Development" };



        //--Because you told that we need to add the book with the category "Computer Networks", 
        //assuming we can Have the same problem with the other categories
        //the simplified approach just creates lists of potential names that would suit each category
        //even though the best approach is to limited input options for a category (but we do not have such task here)
        public static List<string> ComputerScience = new List<string>
    {
        "Data Structure",
        "Computing",
        "Artificial Intelligence",
        "Machine Learning",
        "Database Systems",
        "Operating Systems",
        "Computer Graphics",
        "Cybersecurity"
    };

        public static List<string> Networking = new List<string>
    {
        "Networks",
        "Network",
        "Computer Networks",
        "Network Security",
        "Wireless Networks",
        "Network Protocols",
        "Internet of Things",
        "Network Administration",
        "Cloud Computing",
        "Network Architecture"
    };

        public static List<string> Mathematics = new List<string>
    {
        "Calculus",
        "Linear Algebra",
        "Discrete Mathematics",
        "Algebra",
        "Number Theory",
        "Mathematical Analysis",
        "Graph Theory"
    };

        public static List<string> SoftwareDevelopment = new List<string>
    {
        "Software Engineering",
        "Programming Languages",
        "Java Programming",
        "Python Programming",
        "C++ Programming",
        "JavaScript Programming",
        "Agile Development",
        "DevOps",
        "Version Control",
        "Software Testing",
        "Mobile App Development"
    };

        //---------------------------
    }
}