using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Author
    {
        private string author;

        public Author() { }
        public Author(string author) => this.author = author;
       

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(author);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
