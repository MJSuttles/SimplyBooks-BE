using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksBookRepository
  {
    Task<List<Book>> GetAllBooksAsync();
    Task<List<Book>> GetBooksByUserAsync(int userId);
    Task<Book?> GetBookWithAuthorDetailsAsync(int id);
  }
}
