using BookStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Data;

public class BookStoreContext : DbContext
{
    public BookStoreContext(DbContextOptions<BookStoreContext> options)
        : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure one-to-many relationship
        modelBuilder.Entity<Author>()
            .HasMany(a => a.Books)
            .WithOne(b => b.Author)
            .HasForeignKey(b => b.AuthorId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Book>()
            .Property(b => b.Price)
            .HasPrecision(18, 2); // Set precision and scale

        base.OnModelCreating(modelBuilder);

        // Add some seed data
        modelBuilder.Entity<Author>().HasData(
            new Author { Id = 1, Name = "Some Author", Email = "someone@example.com", Biography = "Some best author", DateOfBirth = new DateTime(1962, 2, 10) }
        );

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "The fault in our starts", ISBN = "123-456-789", PublishedDate = DateTime.Now, Price = 99.99m, AuthorId = 1 }
        );
    }
}