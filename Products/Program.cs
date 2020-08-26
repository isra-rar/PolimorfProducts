using Products.Entities;
using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("Noteebok", 1100.00);
            Product productUsed = new UsedProduct(DateTime.Today,"Iphone", 1100.00);
            Product productImported = new ImportedProduct("Tablet", 1100.00, 20.00);

            Console.WriteLine(productImported.PriceTag());
            Console.WriteLine(product.PriceTag());
            Console.WriteLine(productUsed.PriceTag());

        }
    }
}
