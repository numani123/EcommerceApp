﻿using ECommerceApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Data
{
   public class ApplicationDbContext : IdentityDbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }

      public DbSet<Product> Products { get; set; }
   }
}
