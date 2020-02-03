using System;

namespace StockManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Insert product");
            Console.WriteLine("2. Get all  products");
            Console.WriteLine("3. Get product by Id");
            Console.WriteLine("4. update product");
            Console.WriteLine("5. delete product");

            var context = new ProductContext();
            context.Database.EnsureCreated();
            var productRepository = new ProductRepository(context);

            var menu = Convert.ToInt32(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine("enter product id");
                var product_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter product name");
                var product_name = Console.ReadLine();
                Console.WriteLine("enter product price");
                var product_price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter product quantity");
                var product_quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(
                    productRepository.AddProduct(product_id, product_name, product_price, product_quantity));
                Console.WriteLine("Product has been added successful");
            }
            else if (menu == 2)
            {

            }
            else if (menu == 3)
            {
            }
            else if (menu == 4)
            {
            }
            else if (menu == 5)
            {
                
            
                
            }



        
        }
    }
}