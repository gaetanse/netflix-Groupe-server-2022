using Microsoft.AspNetCore.Mvc;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;

namespace netflixAspNetCore.Controllers
{
    public class AvatarController : Controller
    {
        [HttpPost("avatar")]
        public bool Index([FromForm] IFormFile file, [FromForm] IFormFile id)
        {
            if (file != null)
            {
                string name = file.FileName;
                using (var memoryStream = new MemoryStream())
                {
                    file.CopyTo(memoryStream);
                    FileStream fileStream = new FileStream("wwwroot/Assets/Avatars/" + name, FileMode.Create, FileAccess.Write);
                    fileStream.Write(memoryStream.ToArray());
                    fileStream.Dispose();
                    
                    /*User user = Netflix.UserRepo.FindById(id);
                    if (user != null)
                    {
                        user.Avatar = name;
                        Console.WriteLine(name);
                        Netflix.Save();
                    }*/
                    return true;
                }
            }
            return false;
        }
    }

}
