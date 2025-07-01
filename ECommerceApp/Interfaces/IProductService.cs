using ECommerceApp.Models;

namespace ECommerceApp.Interfaces
{
   public interface IProductService
   {
      void AddProduct(CreateProductViewModel product);
   }
}
