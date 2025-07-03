using ECommerceApp.Models;

namespace ECommerceApp.Interfaces
{
   public interface IProductService
   {
      bool AddProduct(CreateProductViewModel product);
   }
}
