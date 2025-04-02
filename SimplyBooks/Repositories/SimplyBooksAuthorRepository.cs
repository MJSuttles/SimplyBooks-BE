using Microsoft.EntityFrameworkCore;
using SimplyBooks.Data;
using SimplyBooks.Interfaces;
using SimplyBooks.Models;

namespace SimplyBooks.Repositories
{
  public class SimplyBooksAuthorRepository : ISimplyBooksAuthorRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly SimplyBooksDbContext _context;

    public SimplyBooksAuthorRepository(SimplyBooksDbContext context)
    {
      _context = context;
    }

    // insert Tasks
  }
}
