using SimplyBooks.Interfaces;
using SimplyBooks.Models;

namespace SimplyBooks.Services
{
  public class SimplyBooksBookService : ISimplyBooksBookService
  {
    // The service layer is responsible for processing business logic.
    // Right now, the service layer is just calling the repository layer.
    // The service layer will call the repository layer to do the actual CRUD operations.
    // The service layer will return the data to the endpoint (controller).

    private readonly ISimplyBooksBookRepository _simplyBooksBookRepository;

    // This constructor is used for dependency injection.
    // We are injecting the IWeatherForecastRepository interface into the WeatherForecastService class.
    // We inject the repository interface instead of the actual repository class.
    // This is because we can easily mock the interface for unit testing.
    // It also makes our code more flexible and easier to maintain.
    // The type of DI used here is called constructor injection.

    public SimplyBooksBookService(ISimplyBooksBookRepository simplyBooksBookRepository)
    {
      _simplyBooksBookRepository = simplyBooksBookRepository;
    }

    // async means that the method is asynchronous.
    // async methods can be awaited using the await keyword.
    // async methods return a Task or Task<T>.
    // Task represents an asynchronous operation that can return a value.
    // Task<T> is a task that returns a value.
    // To get the value, we use the await keyword.

    // insert Task<Book>
  }
}
