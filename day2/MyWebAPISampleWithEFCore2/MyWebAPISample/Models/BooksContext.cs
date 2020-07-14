using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPISample.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Publisher).HasMaxLength(20);

            var books = Enumerable.Range(1, 1000).Select(x => new Book { BookId = x, Title = $"title {x}", Publisher = "sample pub", Isbn = $"4711{x}" });
            modelBuilder.Entity<Book>().HasData(books);

        }

        public DbSet<Book> Books { get; set; } = null!;

    }
}
