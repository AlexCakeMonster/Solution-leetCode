using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Content
    {
        private string content;

        public Content() { }
        public Content(string content) => this.content = content;
        

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
