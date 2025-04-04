using Microsoft.EntityFrameworkCore.Diagnostics;
using SimplyBooks.Interfaces;
using SimplyBooks.Models;
using SimplyBooks.Services;

namespace SimplyBooks.Endpoint
{
  public static class BookEndpoints
  {
    // The endpoint layer is responsible for handling HTTP requests.
    // The endpoint layer will call the service layer to process business logic.
    // The endpoint layer will return the data to the client.
    // The endpoint layer is the entry point for the client to access the application.
    // We must register this MapWeatherEndpoints method in the Program.cs file.
    // You can click the reference to see where it is registered in the Program.cs file.

    public static void MapBookEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/books").WithTags(nameof(Book));

      group.MapGet("/", async (ISimplyBooksBookService simplyBooksBookService) =>
      {
        return await simplyBooksBookService.GetAllBooksAsync();
      })
      .WithName("GetAllBooks")
      .WithOpenApi()
      .Produces<List<Book>>(StatusCodes.Status200OK);

      group.MapGet("/{userId}", async (int userId, ISimplyBooksBookService simplyBooksBookService) =>
      {
        return await simplyBooksBookService.GetBooksByUserAsync(userId);
      })
      .WithName("GetBooksByUser")
      .WithOpenApi()
      .Produces<List<Book>>(StatusCodes.Status200OK);

      group.MapGet("/book-with-author-details", async (int id, ISimplyBooksBookService simplyBooksBookService) =>
      {
        return await simplyBooksBookService.GetBookWithAuthorDetailsAsync(id);
      })
      .WithName("GetBookWithAuthorDetails")
      .WithOpenApi()
      .Produces<Book?>(StatusCodes.Status200OK);


    }
  }
}
