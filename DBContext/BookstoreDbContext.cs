using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using first_EF.models;
using Microsoft.EntityFrameworkCore;
namespace first_EF.NewFolder
{
    internal class BookstoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Bookstore;Trusted_Connection=True;");
        }
        public DbSet<Author> Authors { get; set; }
       public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(a =>
            {
                a.Property(a => a.Title)
                    .IsRequired(true)
                    .HasMaxLength(150);
                a.Property(p => p.Price)
                    .HasColumnType("decimal(8,2)");
                a.Property(p => p.Price);
            });
        }
    }
}
