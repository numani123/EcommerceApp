using ECommerceApp.Entities;
using ECommerceApp.Interfaces;
using ECommerceApp.Models;
using ECommerceApp.Services;
using Moq;

namespace ECommerceApp.Test
{

   [TestFixture]
   public class ProductServiceTest
   {
      [SetUp]
      public void Setup()
      {

      }

      [TearDown]
      public void TearDown() { }

      [Test]
      public void AddProduct_ShouldCallRepositoryAdd_WithCorrectProduct()
      {
         // Arrange
         string name = "Test Product";
         string description = "Test Description.";
         decimal price = 19.99m;

         var mockRepo = new Mock<IProductRepository>();
         var productService = new ProductService(mockRepo.Object);

         var createModel = new CreateProductViewModel
         {
            Name = name,
            Description = description,
            Price = price
         };

         // Act
         productService.AddProduct(createModel);

         // Assert
         mockRepo.Verify(repo => repo.Add(It.Is<Product>(
             p => p.Name == name &&
                  p.Description == description &&
                  p.Price == price
         )), Times.Once);
      }


   }
}