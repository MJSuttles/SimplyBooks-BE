using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using SimplyBooks.Data;
using SimplyBooks.Interfaces;
using SimplyBooks.Models;

namespace SimplyBooks.Repositories
{
  public class SimplyBooksBookRepository : ISimplyBooksBookRepository
  {
    // The repository layer is responsible for CRUD operations.
    // This repository class implements the IWeatherForecastRepository interface.
    // Remember: the interface is a contract that defines methods that a class MUST implement.
    // The repository layer will call the database context to do the actual CRUD operations.
    // The repository layer will return the data to the service layer.

    private readonly SimplyBooksDbContext _context;

    public SimplyBooksBookRepository(SimplyBooksDbContext context)
    {
      _context = context;
    }

    // Get all books

    public async Task<List<Book>> GetAllBooksAsync()
    {
      return await _context.Books.ToListAsync();
    }

    // Get all books by user

    public async Task<List<Book>> GetBooksByUserAsync(int userId)
    {
      return await _context.Books
        .Where(b => b.UserId == userId)
        .Include(b => b.Author)
        .ToListAsync();
    }

    // Get a single book with author details

    public async Task<Book?> GetBookWithAuthorDetailsAsync(int id)
    {
      return await _context.Books
        .Include(b => b.Author)
        .SingleOrDefaultAsync(b => b.Id == id);
    }

    // Create a Book

    public async Task<Book> CreateBookAsync(Book book)
    {
      _context.Books.Add(book);
      await _context.SaveChangesAsync();
      return book;
    }

    // Update a Book

    public async Task<Book> UpdateBookAsync(int id, Book book)
    {
      var existingBook = await _context.Books.FindAsync(id);
      if (existingBook == null)
      {
        return null;
      }
      existingBook.Title = book.Title;
      existingBook.Description = book.Description;
      existingBook.Image = book.Image;
      existingBook.Price = book.Price;
      existingBook.Sale = book.Sale;
      await _context.SaveChangesAsync();
      return book;
    }

    // Delete a Book

    public async Task<Book> DeleteBookAsync(int id)
    {
      var bookToDelete = await _context.Books
        .SingleOrDefaultAsync(b => b.Id == id);

      if (bookToDelete == null)
      {
        return null;
      }
      _context.Books.Remove(bookToDelete);
      await _context.SaveChangesAsync();

      return bookToDelete;
    }
  }
}
