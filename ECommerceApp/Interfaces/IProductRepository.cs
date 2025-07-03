using ECommerceApp.Entities;

namespace ECommerceApp.Interfaces
{
   public interface IProductRepository
   {
      IList<Product> GetAllProducts();
      void Add(Product product);
   }
}
