using System.Diagnostics;
using ECommerceApp.Interfaces;
using ECommerceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApp.Controllers
{
   public class ProductController : Controller
   {
      private readonly ILogger<ProductController> _logger;
      private readonly IProductService _ProductService;

      public ProductController(ILogger<ProductController> logger, IProductService productService)
      {
         _logger = logger;
         _ProductService = productService;
      }

      public IActionResult Index()
      {
         return View();
      }

      [HttpPost]
      [ValidateAntiForgeryToken]
      public IActionResult Create(CreateProductViewModel model)
      {
         _ProductService.AddProduct(model);

         return RedirectToAction("Index", "Product");
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
