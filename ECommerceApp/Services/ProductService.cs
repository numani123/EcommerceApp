using System.ComponentModel.DataAnnotations;
using ECommerceApp.Data;
using ECommerceApp.Entities;
using ECommerceApp.Interfaces;
using ECommerceApp.Models;

namespace ECommerceApp.Services
{
   public class ProductService : IProductService
   {

      private readonly ApplicationDbContext applicationDbContext;

      public ProductService(ApplicationDbContext _context)
      {
         applicationDbContext = _context;
      }

      public void AddProduct(CreateProductViewModel product)
      {
         var context = new ValidationContext(product, serviceProvider: null, items: null);

         var results = new List<ValidationResult>();
         bool isValid = Validator.TryValidateObject(product, context, results, validateAllProperties: true);

         if (!isValid)
         {
            foreach (var validationResult in results)
            {
               System.Diagnostics.Debug.WriteLine(validationResult.ErrorMessage);
            }
            return;
         }

         Product newProduct = new Product
         {
            Name = product.Name,
            Description = product.Description,
            Price = product.Price.HasValue ? product.Price.Value : 0
         };

         applicationDbContext.Products.Add(newProduct);
      }
   }
}
