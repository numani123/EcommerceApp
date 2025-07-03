using System.ComponentModel.DataAnnotations;

namespace ECommerceApp.Models
{
   public class CreateProductViewModel
   {
      [Required(ErrorMessage = "Product name is required.")]
      public string Name { get; set; }

      [Required(ErrorMessage = "Description is required.")]
      public string Description { get; set; }

      [Required(ErrorMessage = "Price is required.")]
      public decimal? Price { get; set; }
   }
}
