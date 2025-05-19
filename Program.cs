using Task13.Models;
using Task13.Services;

class Program
{
    static void Main()
    {
        Market market = new Market(1);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("         PRODUCT MARKET");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Sell product");
            Console.WriteLine("3. View products");
            Console.WriteLine("4. Exit");
            Console.WriteLine("=================================");
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("--- Add Product ---");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine());

                    Console.Write("Quantity: ");
                    int count = int.Parse(Console.ReadLine());

                    market.AddProduct(new Product(name, price, count));
                    break;

                case "2":
                    Console.WriteLine("--- Sell Product ---");
                    Console.Write("Enter the product name: ");
                    string sellName = Console.ReadLine();
                    market.SellProduct(sellName);
                    market.ProductLimit++;
                    break;

                case "3":
                    Console.WriteLine("--- Product List ---");
                    market.ShowProducts();
                    break;

                case "4":
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please select between 1 and 4.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
    }
}
