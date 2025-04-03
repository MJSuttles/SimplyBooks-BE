using SimplyBooks.Models;

namespace SimplyBooks.Data
{
  public class UserData
  {
    public static List<User> Users = new()
    {
      new User { Id = 1, UserName = "skylineVibe42", Email = "skylinevibe42@gmail.com" },
      new User { Id = 2, UserName = "crimsonOtter9", Email = "crimson.otter9@yahoo.com" },
      new User { Id = 3, UserName = "frostNova_88", Email= "frostnova_88@outlook.com" }
    };
  }
}
