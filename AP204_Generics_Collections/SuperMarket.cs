using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Generics_Collections
{
    class SuperMarket<T,U> /*where T : class,ICollection where U:struct*/
    {
        public T[] Prices;
        public U[] Products;

        public SuperMarket()
        {
            Prices = new T[0];
            Products = new U[0];
        }

        public void Add(T price, U product)
        {
            Array.Resize(ref Prices, Prices.Length + 1);
            Prices[Prices.Length - 1] = price;

            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public T[] GetPrices()
        {
            return Prices;
        }

        public U[] GetProducts()
        {
            return Products;
        }


    }
}
