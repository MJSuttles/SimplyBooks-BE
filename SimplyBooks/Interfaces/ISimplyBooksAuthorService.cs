using SimplyBooks.Models;

namespace SimplyBooks.Interfaces
{
  public interface ISimplyBooksAuthorService
  {
    Task<List<Author>> GetAllAuthorsAsync();
    Task<List<Author>> GetAuthorsByUserAsync(int userId);
    Task<Author?> GetAuthorWithBooksAsync(int authorId);
    Task<Author> CreateAuthorAsync(Author author);
    Task<Author> UpdateAuthorAsync(int Id, Author author);
    Task<Author?> DeleteAuthorWithBooksAsync(int authorId);
  }
}
