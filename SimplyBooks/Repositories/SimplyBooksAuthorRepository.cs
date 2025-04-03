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

    // Get authors
    public async Task<List<Author>> GetAllAuthorsAsync()
    {
      return await _context.Authors.ToListAsync();
    }

    // Get authors by user
    public async Task<List<Author>> GetAuthorsByUserAsync(int userId)
    {
      return await _context.Authors
              .Where(a => a.UserId == userId)
              .Include(a => a.Books)
              .ToListAsync();
    }

    // Get a single author with his/her books

    public async Task<Author?> GetAuthorWithBooksAsync(int authorId)
    {
      return await _context.Authors
          .Include(a => a.Books)
          .SingleOrDefaultAsync(a => a.Id == authorId);
    }

    //   return Results.Ok(author);
    // };

    // Create an author



    // Update an author



    // Delete an author and his/her books
  }
}
