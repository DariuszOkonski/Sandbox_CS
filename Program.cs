using ClassLibrary;

namespace Sandbox
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string developerName = "John";

            Product product1 = new Product();
            Product.TotalNoProducts++;

            Product product2 = new Product();
            Product.TotalNoProducts++;

            Product product3 = new Product();
            Product.TotalNoProducts++;

            product1.SetProductID(1001);
            product1.SetProductName("Mobile");
            //product1.cost = 20000;
            product1.SetCost(20000);

            product1.SetQuantityInStock(1200);

            product2.SetProductID(1002);
            product2.SetProductName("Laptop");

            //product2.cost = 45000;
            product2.SetCost(45000);

            product2.SetQuantityInStock(3400);

            product3.SetProductID(1003);
            product3.SetProductName("Speakers");
            //product3.cost = 36000;
            product3.SetCost(36000);

            product3.SetQuantityInStock(800);

            int totlaQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();

            product1.CalculateTax();
            product2.CalculateTax();
            product3.CalculateTax();

            Console.WriteLine("Product ID: " + product1.GetProductID());
            Console.WriteLine("Product Name: " + product1.GetProductName());
            Console.WriteLine("Product Cost: " + product1.GetCost());
            Console.WriteLine("Product Quantity: " + product1.GetQuantityInStock());
            Console.WriteLine("Product date purchase: " + product1.GetDateOfPurchase());
            Console.WriteLine("Product tax: " + product1.GetTax());

            Console.WriteLine("");
            Console.WriteLine("Total Quantity: " + totlaQuantity);
            Console.WriteLine("Total num of products: " + Product.TotalNoProducts);
            Console.WriteLine("Category of products: " + Product.CategoryName);
        }
    }
}
