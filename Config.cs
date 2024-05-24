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
    }
}