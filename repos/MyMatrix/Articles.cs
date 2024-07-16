using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{
   
    class Articles
    {
         string   productName;
         string   nameOfShop;
         int   productPrice;

        

        public string ProductName
        {
            get => productName;           
        }

        public string NameOfShop
        {
            get => nameOfShop;            
        }

        public int ProductPrice
        {
            get => productPrice;            
        }
        /// <summary>
        /// creates an instance of a class and takes three parameters
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="nameOfShop"></param>
        /// <param name="productPrice"></param>
        public Articles(string productName, string nameOfShop, int productPrice)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.nameOfShop = nameOfShop;
        }
    }
}
