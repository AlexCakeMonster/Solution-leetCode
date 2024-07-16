using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article

{
    class Store
    {
        /*Обеспечить следующие возможности:
        • вывод информации о товаре по номеру с помощью индекса;
        • вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров
        нет, выдать соответствующее сообщение;
        Написать программу, вывода на экран информацию о товаре.
        */
        
        Articles[] articles = new Articles[0];

       
        public int ArticleSize
        {
            get => articles.Length;
        }

        public Articles this[int index]
        {
            set
            {
                if(index < articles.Length && index >= 0)
                {
                    articles[index] = value;
                }
                else
                {
                    Array.Resize(ref articles, articles.Length + 1);
                    articles[articles.Length - 1] = value;
                }   

            }
        }

        public void NameNequestAndSearch()
        {
            string name;
            Console.Write("Введите название тавара: ");
            name = Console.ReadLine();
            SearchProductByName(name);
        }

        public void IndexNequestAndSearch()
        {
            int index;
            Console.Write("Введите индех тавара: ");
            index = Convert.ToInt32( Console.ReadLine());
            searchForProductByIndex(index);
        }


        private void SearchProductByName(string NameProduct)
        {
            bool productFound = false;

            for (int i = 0; i < articles.Length; i++)
            {
                if(NameProduct == articles[i].ProductName)
                {
                    searchForProductByIndex(i + 1);
                    productFound = true;
                }             
                
            }
            if (!productFound)
            {
                Console.WriteLine("Такого тавара нет.");
            }
        }



        private void searchForProductByIndex(int index)
        {
            if (index - 1 < articles.Length && index -1 >= 0)
            {
                Console.WriteLine($"Название продукта:{articles[index-1].ProductName}.\nЦена: {articles[index-1].ProductPrice} р.\nМагазин в котором есть данный товар: {articles[index-1].NameOfShop}.");
            }
            else
            {
                Console.WriteLine("Тавара под таким индексем нет.");
            }
        }
    }
}
