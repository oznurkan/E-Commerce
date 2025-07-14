using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;


public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>
            {
                new Product{ Id=1, Name="Iphone 15", Description="Telefon açıklaması", ImageUrl="1.jpg", Price=70000, IsActive=false, Stock=1 },
                new Product{ Id=2, Name="Iphone 15 Pro", Description="Telefon açıklaması", ImageUrl="2.jpg", Price=78000, IsActive=false, Stock=5 },
                new Product{ Id=3, Name="Iphone 15 Pro Max", Description="Telefon açıklaması", ImageUrl="3.jpg", Price=85000, IsActive=true, Stock=100 },
                new Product{ Id=4, Name="Iphone 16", Description="Telefon açıklaması", ImageUrl="4.jpg", Price=890000, IsActive=true, Stock=73 },
                new Product{ Id=5, Name="Iphone 16 Pro", Description="Telefon açıklaması", ImageUrl="5.jpg", Price=90000, IsActive=true, Stock=100 },
                new Product{ Id=6, Name="Iphone 16 Pro Max", Description="Telefon açıklaması", ImageUrl="6.jpg", Price=100000, IsActive=false, Stock=87 },
                new Product{ Id=7, Name="Iphone 17", Description="Telefon açıklaması", ImageUrl="7.jpg", Price=120000, IsActive=true, Stock=92 },
                new Product{ Id=8, Name="Iphone 17 Pro", Description="Telefon açıklaması", ImageUrl="7.jpg", Price=130000, IsActive=true, Stock=65 },
                new Product{ Id=9, Name="Iphone 17 Pro Max", Description="Telefon açıklaması", ImageUrl="7.jpg", Price=150000, IsActive=true, Stock=10 },
                new Product{ Id=10, Name="Apple Watch Series 1", Description="Apple Watch Series", ImageUrl="1.jpg", Price=70000, IsActive=true, Stock=100  },
                new Product{ Id=11, Name="Apple Watch Series 2", Description="Telefon açıklaması", ImageUrl="2.jpg", Price=80000, IsActive=true, Stock=100  },
                new Product{ Id=12, Name="Apple Watch Series 3", Description="Telefon açıklaması", ImageUrl="3.jpg", Price=90000, IsActive=false, Stock=100  },
                new Product{ Id=13, Name="Xiaomi Redmi Watch 1", Description="Telefon açıklaması", ImageUrl="4.jpg", Price=100000, IsActive=true, Stock=100  },
                new Product{ Id=14, Name="Xiaomi Redmi Watch 2", Description="Telefon açıklaması", ImageUrl="5.jpg", Price=100000, IsActive=true, Stock=100  },
                new Product{ Id=15, Name="Xiaomi Redmi Watch 3", Description="Telefon açıklaması", ImageUrl="6.jpg", Price=100000, IsActive=true, Stock=100  },
                new Product{ Id=16, Name="Xiaomi Redmi Watch 4", Description="Telefon açıklaması", ImageUrl="7.jpg", Price=100000, IsActive=true, Stock=100  }


            }

        );
    }
}