using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Book
    {
        Author author;
        Title title;
        Content content;

        public string Author
        {
            set => AuthorText(value);
        }

        public string Title
        {
            set => TitleText(value);
        }

        public string Content
        {
            set => ContentText(value);
        }
        private void AuthorText(string text) => author = new Author(text);        

        private void TitleText(string text) => title = new Title(text);        

        private void ContentText(string text) => content = new Content(text);        

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}
