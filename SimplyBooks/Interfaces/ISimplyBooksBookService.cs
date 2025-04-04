using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksBookService
  {
    Task<List<Book>> GetAllBooksAsync();
  }
}
