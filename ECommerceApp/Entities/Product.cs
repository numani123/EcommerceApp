using ECommerceApp.Interfaces;

namespace ECommerceApp.Entities
{
   public class Product : IEntity
   {
      // Constructor
      public Product()
      {
         Id = Guid.NewGuid();
      }

      public Guid Id { get; set; }

      public string Name { get; set; }

      public string Description { get; set; }

      public decimal Price { get; set; }
   }
}
