Name of the Project: Hymnal-History

Overview of the project:

SimplyBooks-BE is the backend setup of the SimplyBooks frontend project. This project is created using C#/.NET and is connected to a Swagger database. I implemented the repository pattern for this project which included breaking the project into multiple folders: Data (AuthorData.cs, BookData.cs, UserData.cs, and SimplyBooksDbContext.cs), Endpoints (AuthorEndpoints.cs and BookEndpoins.cs), Interfaces (ISimplyBooksAuthorRepository, ISimplyBooksBookRepository.cs, ISimplyBooksAuthorService.cs, and ISimplyBooksBookService.cs), Models (Author.cs, Book.cs, and User.cs), Repositories (SimplyBooksAuthorRepository.cs and SimplyBooksBookRepository), and Services (SimplyBooksAuthorServices.cs and SimplyBooksBookService.cs).

App Features:

This app features initial seeded data from the Data folder as well as full CRUD (Create, Read, Update, and Delete) features for both Authors and Books. Both Authors and Books categories are connected.

The following calls are included.

Authors:

GetAllAuthorsAsync
GetAuthorsByUserAsync
GetAuthorWithBooksAsync
CreateAuthorAsync
UpdateAuthorAsync
DeleteAuthorWithBooksAsync

Books:

GetAllBooksAsync
GetBooksByUserAsync
GetBookWithAuthorDetailsAsync
CreateBookAsync
UpdateBookAsync
DeleteBookAsync

Link to ERD: https://dbdiagram.io/d/Almost-Amazon-60315ba6fcdcb6230b20bbaa?utm_source=dbdiagram_embed&utm_medium=bottom_open

Description of the user and the problem you are solving for them:

Users of the SimplyBooks website need to be able to have full CRUD operations for both Authors and Books available on the website.

Screenshots of your project:

![alt text](<SimplyBooks-BE Swagger Screenshot.png>)

List of contributors and links to their GH profiles: Brian Suttles (https://github.com/MJSuttles)

Link to Loom video walkthrough of your app (no more than 1 minute long! Make it great):

https://www.loom.com/share/b60e10cd5cf948d99e3ebe9afa1fafc6
