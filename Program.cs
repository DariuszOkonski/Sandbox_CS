using ClassLibrary;

namespace Sandbox
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            product1.productID = 1001;
            product1.productName = "Mobile";
            product1.cost = 20000;
            product1.quantityInStock = 1200;

            product2.productID = 1002;
            product2.productName = "Laptop";
            product2.cost = 45000;
            product2.quantityInStock = 3400;

            product3.productID = 1003;
            product3.productName = "Speakers";
            product3.cost = 36000;
            product3.quantityInStock = 800;

            int totlaQuantity = product1.quantityInStock + product2.quantityInStock + product3.quantityInStock;

            Console.WriteLine("Product ID: " + product1.productID);
            Console.WriteLine("Product Name: " + product1.productName);
            Console.WriteLine("Product Cost: " + product1.cost);
            Console.WriteLine("Product Quantity: " + product1.quantityInStock);
            Console.WriteLine("Total Quantity: " + totlaQuantity);
        }
    }
}
