using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
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

      group.MapGet("/{userId}", async (int userId, ISimplyBooksAuthorService simplyBooksAuthorService) =>
      {
        return await simplyBooksAuthorService.GetAuthorsByUserAsync(userId);
      })
      .WithName("GetAuthorsByUser")
      .WithOpenApi()
      .Produces<List<Author>>(StatusCodes.Status200OK);

      group.MapGet("/authors-with-books", async (int authorId, ISimplyBooksAuthorService simplyBooksAuthorService) =>
      {
        return await simplyBooksAuthorService.GetAuthorWithBooksAsync(authorId);
      })
      .WithName("GetAuthorsWithBooks")
      .WithOpenApi()
      .Produces<Author?>(StatusCodes.Status200OK);

      group.MapPost("/", async (ISimplyBooksAuthorService simplyBooksAuthorService, Author author) =>
      {
        var createdAuthor = await simplyBooksAuthorService.CreateAuthorAsync(author);
        return Results.Created($"/api/authors/{createdAuthor.Id}", author);
      })
      .WithName("CreatedAuthor")
      .WithOpenApi()
      .Produces<Author>(StatusCodes.Status201Created)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapPut("/{id}", async (ISimplyBooksAuthorService simplyBooksAuthorService, int id, Author author) =>
      {
        var updatedAuthor = await simplyBooksAuthorService.UpdateAuthorAsync(id, author);
        return Results.Ok(updatedAuthor);
      })
      .WithName("UpdateAuthor")
      .WithOpenApi()
      .Produces<Author>(StatusCodes.Status201Created)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapDelete("/{authorId}", async (ISimplyBooksAuthorService simplyBooksAuthorService, int authorId) =>
      {
        var deletedAuthor = await simplyBooksAuthorService.DeleteAuthorWithBooksAsync(authorId);
        return Results.NoContent();
      })
      .WithName("DeletedAuthor")
      .WithOpenApi()
      .Produces<Author>(StatusCodes.Status204NoContent);
    }
  }
}
