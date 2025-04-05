using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksBookRepository
  {
    // An interface is a contract that defines the signature of the functionality.
    // It defines a set of methods that a class that inherits the interface MUST implement.
    // The interface is a mechanism to achieve abstraction.
    // Interfaces can be used in unit testing to mock out the actual implementation.

    Task<List<Book>> GetAllBooksAsync();
    Task<List<Book>> GetBooksByUserAsync(int userId);
    Task<Book?> GetBookWithAuthorDetailsAsync(int id);
    Task<Book> CreateBookAsync(Book book);
    Task<Book> UpdateBookAsync(int id, Book book);
    Task<Book> DeleteBookAsync(int id);
  }
}
