using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            book1.Author = "Дюма";
            book1.Title = "Три Мушкитёра";
            book1.Content = "Бла бла бла";
            book2.Author = "Ger";
            book2.Title = "fdds";
            book2.Content = "hhhhhhhhhhhhhhhhhhhhhh";
            book1.Show();
            book2.Show();


            Console.ReadKey();

        }
    }
}
