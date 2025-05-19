using Task13.Interfaces;

namespace Task13.Models;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Count { get; set; }

    public Product(string name, double price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
        
    }
}