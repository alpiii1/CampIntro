using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations ! Added to cart : " + product.Name);

        }

        public void Add2(string productName, string explanation, double price, int amountStock)
        {
            Console.WriteLine("Congratulations ! Added to cart : " + productName);
        }
    }
}
