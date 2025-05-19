using Task13.Models;
namespace Task13.Interfaces
{
    public interface IStore
    {
        List<Product> Products { get; set; }
        int ProductLimit { get; set; }
        double TotalIncome { get; set; }

        void AddProduct(Product product);
        void SellProduct(string name);
    }
}