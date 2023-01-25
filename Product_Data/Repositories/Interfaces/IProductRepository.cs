using Product_Data.Models;

namespace Product_Data.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();

        public Boolean UpdatesProduct(Double cost1, Double cost2, Double cost3, Double cost4);
    }
}
