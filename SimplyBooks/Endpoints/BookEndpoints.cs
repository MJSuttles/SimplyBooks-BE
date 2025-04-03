using Microsoft.EntityFrameworkCore.Diagnostics;
using SimplyBooks.Interfaces;
using SimplyBooks.Models;

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

      // insert Book API Calls
    }
  }
}
