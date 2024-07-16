using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store();
            Articles argIterator1 = new Articles("сыр", "Ашан", 300);
            Articles argIterator2 = new Articles("хлеб", "Спар", 50);
            Articles argIterator3 = new Articles("соль", "Кар", 20);
            Articles argIterator4 = new Articles("сахар", "Фан", 60);

            store1[0] = argIterator1;
            store1[1] = argIterator2;
            store1[2] = argIterator3;
            store1[3] = argIterator4;
            


            store1.NameNequestAndSearch();
            store1.IndexNequestAndSearch();

            Console.ReadKey();

        }
    }
}
