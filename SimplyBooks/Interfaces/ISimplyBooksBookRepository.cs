using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksBookRepository
  {
    Task<List<Book>> GetAllBooksAsync();
  }
}
