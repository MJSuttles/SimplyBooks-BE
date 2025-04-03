using SimplyBooks.Models;

namespace SimplyBooks.Data
{
  public class AuthorData
  {
    public static List<Author> Authors = new()
    {
      new() { Id = 1, FirstName = "Lena", LastName = "Marquez", Email = "lena.marquez@example.com", Image = "https://example.com/images/lena.jpg", Favorite = true, UserId = 1 },
      new() { Id = 2, FirstName = "Jasper", LastName = "Thorne", Email = "jasper.thorne@example.com", Image = "https://example.com/images/jasper.jpg", Favorite = false, UserId = 2 },
      new() { Id = 3, FirstName = "Mira", LastName = "Ellwood", Email = "mira.ellwood@example.com", Image = "https://example.com/images/mira.jpg", Favorite = true, UserId = 3 },
      new() { Id = 4, FirstName = "Ronan", LastName = "Vale", Email = "ronan.vale@example.com", Image = "https://example.com/images/ronan.jpg", Favorite = false, UserId = 1 },
      new() { Id = 5, FirstName = "Tessa", LastName = "Hart", Email = "tessa.hart@example.com", Image = "https://example.com/images/tessa.jpg", Favorite = true, UserId = 2 }
    };
  }
}
