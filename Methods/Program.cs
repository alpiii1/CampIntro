using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Explanation = "Amasya's Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Explanation = "Diyarbakır's Watermelon";

            Product[] products = new Product[] {product1,product2 };

            //type safe 
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("----------Methods-----------");
            //encapsulation
            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            cartManager.Add2("Pear", "Green Pear", 12,10);
            cartManager.Add2("Apple", "Green Apple", 12,9);
            cartManager.Add2("Watermelon", "Diyarbakır's Watermelon", 12,8);
        }
    }
}


//Do not repeat yourself ! - DRY - Clear Code - Best Practice
