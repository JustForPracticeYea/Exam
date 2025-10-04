using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Classes
{
    public class Book
    {
        public string Title;
        public string Author;
        public string Genre;
        public Book(string Title, string Author, string Genre)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
        }
    }
}
