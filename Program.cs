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

            product1.quantityInStock = 1200;

            product2.SetProductID(1002);
            product2.SetProductName("Laptop");

            //product2.cost = 45000;
            product2.SetCost(45000);

            product2.quantityInStock = 3400;

            product3.SetProductID(1003);
            product3.SetProductName("Speakers");
            //product3.cost = 36000;
            product3.SetCost(36000);

            product3.quantityInStock = 800;

            int totlaQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;

            product1.CalculateTax();
            product2.CalculateTax();
            product3.CalculateTax();

            Console.WriteLine("Product ID: " + product1.GetProductID());
            Console.WriteLine("Product Name: " + product1.GetProductName());
            Console.WriteLine("Product Cost: " + product1.GetCost());
            Console.WriteLine("Product Quantity: " + product1.quantityInStock);
            Console.WriteLine("Product date purchase: " + product1.dateOfPurchase);
            Console.WriteLine("Product tax: " + product1.tax);

            Console.WriteLine("");
            Console.WriteLine("Total Quantity: " + totlaQuantity);
            Console.WriteLine("Total num of products: " + Product.TotalNoProducts);
            Console.WriteLine("Category of products: " + Product.CategoryName);
        }
    }
}
