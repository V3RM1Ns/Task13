using Task13.Interfaces;
using Task13.Models;
namespace Task13.Services;
public class Market : IStore
{
    public List<Product> Products { get; set; } = new List<Product>();
    public int ProductLimit { get; set; }
    public double TotalIncome { get; set; }
    public Market(int limit)
    {
        ProductLimit = limit;
        Products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        if (Products.Count >= ProductLimit)
        {
            Console.WriteLine("Limit is full.can not add any product");
            return;
        }

        foreach (Product p in Products)
        {
            if (p.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Already have this product.");
                return;
            }
        }

        Products.Add(product);
        Console.WriteLine("Product added");
    }

    public void SellProduct(string name)
    {
        foreach (var p in Products)
        {
            if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                if (p.Count > 0)
                {
                    p.Count--;
                    TotalIncome += p.Price;
                    Console.WriteLine($"Product sold: {p.Name}, Income: {p.Price}AZN,Stock Left: {p.Count}");
                }
                else
                {
                    Console.WriteLine("No stock left");
                }
                return;
            }
        }

        Console.WriteLine($"Can not find product called {name}.");
    }

    public void ShowProducts()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("there is not products yet.");
            return;
        }
        foreach (var p in Products)
        {
            Console.WriteLine($"Name: {p.Name}, Price: {p.Price}AZN, Count: {p.Count}");
        }
    }
}