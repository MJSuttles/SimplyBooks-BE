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

      group.MapPost("/", async (ISimplyBooksBookService simplyBooksBookSerivce, Book book) =>
      {
        var createdBook = await simplyBooksBookSerivce.CreateBookAsync(book);
        return Results.Created($"/books/{createdBook.Id}", book);
      })
      .WithName("CreateBook")
      .WithOpenApi()
      .Produces<Book>(StatusCodes.Status201Created)
      .Produces<Book>(StatusCodes.Status400BadRequest);

      group.MapPut("/{id}", async (ISimplyBooksBookService simplyBooksBookService, int id, Book book) =>
      {
        var updatedBook = await simplyBooksBookService.UpdateBookAsync(id, book);
        return Results.Ok(updatedBook);
      })
      .WithName("UpdateBook")
      .WithOpenApi()
      .Produces<Book>(StatusCodes.Status201Created)
      .Produces(StatusCodes.Status400BadRequest);

      group.MapDelete("/{id}", async (ISimplyBooksBookService simplyBooksBookService, int id) =>
      {
        var deletedBook = await simplyBooksBookService.DeleteBookAsync(id);
        return Results.NoContent();
      })
      .WithName("DeletedBook")
      .WithOpenApi()
      .Produces<Book>(StatusCodes.Status204NoContent);
    }
  }
}
