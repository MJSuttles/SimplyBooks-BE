using System.Threading.Tasks;
using SimplyBooks.Interfaces;
using SimplyBooks.Models;
using SimplyBooks.Repositories;

namespace SimplyBooks.Endpoint
{
  public static class AuthorEndpoints
  {
    // The endpoint layer is responsible for handling HTTP requests.
    // The endpoint layer will call the service layer to process business logic.
    // The endpoint layer will return the data to the client.
    // The endpoint layer is the entry point for the client to access the application.
    // We must register this MapWeatherEndpoints method in the Program.cs file.
    // You can click the reference to see where it is registered in the Program.cs file.

    public static void MapAuthorEndpoints(this IEndpointRouteBuilder routes)
    {
      var group = routes.MapGroup("/api/authors").WithTags(nameof(Author));

      group.MapGet("/", async (ISimplyBooksAuthorRepository simplyBooksAuthorRepository) =>
      {
        return await simplyBooksAuthorRepository.GetAllAuthorsAsync();
      })
      .WithName("GetAllAuthors")
      .WithOpenApi()
      .Produces<List<Author>>(StatusCodes.Status200OK);

      group.MapGet("/{userId}", async (int userId, ISimplyBooksAuthorRepository simplyBooksAuthorRepository) =>
      {
        return await simplyBooksAuthorRepository.GetAuthorsByUserAsync(userId);
      })
      .WithName("GetAuthorsByUser")
      .WithOpenApi()
      .Produces<List<Author>>(StatusCodes.Status200OK);

      group.MapGet("/authors-with-books", async (int authorId, ISimplyBooksAuthorRepository simplyBooksAuthorRepository) =>
      {
        return await simplyBooksAuthorRepository.GetAuthorWithBooksAsync(authorId);
      })
      .WithName("GetAuthorsWithBooks")
      .WithOpenApi()
      .Produces<Author?>(StatusCodes.Status200OK);
    }


  }
}
