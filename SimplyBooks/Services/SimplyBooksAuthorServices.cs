using SimplyBooks.Interfaces;
using SimplyBooks.Models;
using SimplyBooks.Repositories;

namespace SimplyBooks.Services
{
  public class SimplyBooksAuthorService : ISimplyBooksAuthorService
  {
    // The service layer is responsible for processing business logic.
    // Right now, the service layer is just calling the repository layer.
    // The service layer will call the repository layer to do the actual CRUD operations.
    // The service layer will return the data to the endpoint (controller).

    private readonly ISimplyBooksAuthorRepository _simplyBooksAuthorRepository;

    // This constructor is used for dependency injection.
    // We are injecting the ISimplyBooksAuthorRepository interface into the SimplyBooksAuthorRepository class.
    // We inject the repository interface instead of the actual repository class.
    // This is because we can easily mock the interface for unit testing.
    // It also makes our code more flexible and easier to maintain.
    // The type of DI used here is called constructor injection.

    public SimplyBooksAuthorService(ISimplyBooksAuthorRepository simplyBooksAuthorRepository)
    {
      _simplyBooksAuthorRepository = simplyBooksAuthorRepository;
    }

    // async means that the method is asynchronous.
    // async methods can be awaited using the await keyword.
    // async methods return a Task or Task<T>.
    // Task represents an asynchronous operation that can return a value.
    // Task<T> is a task that returns a value.
    // To get the value, we use the await keyword.

    public async Task<List<Author>> GetAllAuthorsAsync()
    {
      return await _simplyBooksAuthorRepository.GetAllAuthorsAsync();
    }

    public async Task<List<Author>> GetAuthorsByUserAsync(int userId)
    {
      return await _simplyBooksAuthorRepository.GetAuthorsByUserAsync(userId);
    }

    public async Task<Author?> GetAuthorWithBooksAsync(int authorId)
    {
      return await _simplyBooksAuthorRepository.GetAuthorWithBooksAsync(authorId);
    }


  }
}
