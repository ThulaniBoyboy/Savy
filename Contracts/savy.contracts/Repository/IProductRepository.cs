using System.Collections.Generic;
using System.Text;
using savy.domain.Entities.Catalog;

namespace savy.contracts.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        Product GetProduct(int id);
        bool RemoveProduct(int id);
        ICollection<Product> GetAllProducts();
    }
}