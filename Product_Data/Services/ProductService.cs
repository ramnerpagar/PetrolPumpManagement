using Product_Data.DataContext;
using Product_Data.Models;
using Product_Data.Repositories;
using Product_Data.Services.Interfaces;

namespace Product_Data.Services
{
    public class ProductService : IProductService
    {
        ProductRepository productRepository;

        public ProductService(ProductDBContext productDBContext) 
        {
            productRepository = new ProductRepository(productDBContext);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productRepository.GetProducts();
        }

        public Boolean UpdatesProduct(Double cost1, Double cost2, Double cost3, Double cost4)
        {
            return productRepository.UpdatesProduct(cost1, cost2, cost3, cost4);
        }
    }
}
