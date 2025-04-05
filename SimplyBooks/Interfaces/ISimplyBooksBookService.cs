using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksBookService
  {
    Task<List<Book>> GetAllBooksAsync();
    Task<List<Book>> GetBooksByUserAsync(int userId);
    Task<Book?> GetBookWithAuthorDetailsAsync(int id);
    Task<Book> CreateBookAsync(Book book);
    Task<Book> UpdateBookAsync(int id, Book book);
  }
}
