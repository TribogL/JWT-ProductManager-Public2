using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWT_ProductManager_Public2.Models;
using Microsoft.EntityFrameworkCore;

namespace JWT_ProductManager_Public2.Data;

public class ApplicationDbContext : DbContext

{
    public DbSet<Product> Products{get; set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
