using Microsoft.EntityFrameworkCore;
using SimplyBooks.Models;

namespace SimplyBooks.Data
{
  public class SimplyBooksDbContext : DbContext
  {
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<User> Users { get; set; }

    public SimplyBooksDbContext(DbContextOptions<SimplyBooksDbContext> context) : base(context) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Author>()
        .HasMany(a => a.Books)
        .WithOne(b => b.Author)
        .HasForeignKey(b => b.AuthorId);

      modelBuilder.Entity<Author>().HasData(AuthorData.Authors);
      modelBuilder.Entity<Book>().HasData(BookData.Books);
      modelBuilder.Entity<User>().HasData(UserData.Users);
    }
  }
}
