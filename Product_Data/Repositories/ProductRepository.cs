using Product_Data.DataContext;
using Product_Data.Models;
using Product_Data.Repositories.Interfaces;

namespace Product_Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext productDBContext;
        public ProductRepository(ProductDBContext productDbContext) 
        {
            this.productDBContext = productDbContext;
        }

        public IEnumerable<Product> GetProducts() 
        {
            try
            {
                return productDBContext.Products_Data.ToList();
            }
            catch
            {
                //left for logging
                return null;
            }
        }

        public Boolean UpdatesProduct(Double cost1, Double cost2, Double cost3, Double cost4)
        {
            try
            {
                var AGO = productDBContext.Products_Data.Where(s => s.tblProductType == "AGO").First();
                AGO.tblCost = cost1;

                var DPK = productDBContext.Products_Data.Where(s => s.tblProductType == "DPK").First();
                DPK.tblCost = cost3;

                var PMS = productDBContext.Products_Data.Where(s => s.tblProductType == "PMS").First();
                PMS.tblCost = cost4;

                var BULK = productDBContext.Products_Data.Where(s => s.tblProductType == "BULK").First();
                BULK.tblCost = cost2;

                productDBContext.SaveChanges();

                return true;
            }
            catch
            {
                //left for logging
                throw null;
            }
        }
    }
}
