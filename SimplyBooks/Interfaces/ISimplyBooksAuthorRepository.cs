using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksAuthorRepository
  {
    // An interface is a contract that defines the signature of the functionality.
    // It defines a set of methods that a class that inherits the interface MUST implement.
    // The interface is a mechanism to achieve abstraction.
    // Interfaces can be used in unit testing to mock out the actual implementation.

    Task<List<Author>> GetAllAuthorsAsync();
    Task<List<Author>> GetAuthorsByUserAsync(int userId);
    Task<Author?> GetAuthorWithBooksAsync(int authorId);

  }
}
