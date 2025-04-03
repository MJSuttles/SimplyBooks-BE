using SimplyBooks.Models;

namespace SimplyBooks.Data
{
  public class BookData
  {
    public static List<Book> Books = new()
    {
      new() { Id = 1, AuthorId = 1, Title = "The Starlit Archive", Description = "A journey through forgotten realms and memory.", Image = "https://example.com/images/starlit.jpg", Price = 19.99m, Sale = true, UserId = 1 },
      new() { Id = 2, AuthorId = 1, Title = "Echoes of the Sun", Description = "Hope and loss in a fractured future.", Image = "https://example.com/images/echoes.jpg", Price = 15.49m, Sale = false, UserId = 1 },
      new() { Id = 3, AuthorId = 2, Title = "Whispers in Fog", Description = "A detective uncovers more than just crime.", Image = "https://example.com/images/fog.jpg", Price = 12.00m, Sale = false, UserId = 2 },
      new() { Id = 4, AuthorId = 2, Title = "The Ivory Lens", Description = "A thriller told through the eyes of a blind photographer.", Image = "https://example.com/images/lens.jpg", Price = 18.25m, Sale = true, UserId = 2 },
      new() { Id = 5, AuthorId = 3, Title = "Fragments of Tomorrow", Description = "A poetic journey through time.", Image = "https://example.com/images/fragments.jpg", Price = 9.99m, Sale = true, UserId = 3 },
      new() { Id = 6, AuthorId = 4, Title = "Midnight Reverie", Description = "Dark fantasy meets introspective drama.", Image = "https://example.com/images/reverie.jpg", Price = 22.95m, Sale = false, UserId = 1 },
      new() { Id = 7, AuthorId = 4, Title = "Ashes & Amber", Description = "A city reborn from the flames of betrayal.", Image = "https://example.com/images/ashes.jpg", Price = 17.50m, Sale = true, UserId = 1 },
      new() { Id = 8, AuthorId = 5, Title = "The Quiet Rebellion", Description = "A librarian incites a revolution with banned books.", Image = "https://example.com/images/rebellion.jpg", Price = 13.75m, Sale = false, UserId = 2 }
    };
  }
}
