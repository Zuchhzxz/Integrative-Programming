using System;

namespace Product
{
    class Program
    {
        public struct Product
        {
            public int code;
            public string description;
            public float price;
        }

        static void Main(string[] args)
        {
            Product product = new Product();

            product.code = 0123456;
            product.description = "Rolex || Watch";
            product.price = 1000;

            Console.WriteLine("Product Code: " + product.code);
            Console.WriteLine("Product description: " + product.description);
            Console.WriteLine("Product price: " + product.price);
        }
    }
}
