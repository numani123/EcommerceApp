using ECommerceApp.Data;
using ECommerceApp.Entities;
using ECommerceApp.Interfaces;

namespace ECommerceApp.Services
{
   public class ProductRepository : IProductRepository
   {
      private readonly ApplicationDbContext applicationDbContext;

      public ProductRepository(ApplicationDbContext context)
      {
         applicationDbContext = context;
      }

      public void Add(Product product)
      {
         applicationDbContext.Products.Add(product);
      }

      public IList<Product> GetAllProducts()
      {
         return applicationDbContext.Products.ToList();
      }
   }
}
