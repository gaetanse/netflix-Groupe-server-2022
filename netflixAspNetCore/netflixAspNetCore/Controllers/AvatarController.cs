using Microsoft.AspNetCore.Mvc;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;

namespace netflixAspNetCore.Controllers
{
    public class AvatarController : Controller
    {

        private IWebHostEnvironment _env;

        public AvatarController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost("avatar")]
        public bool Index([FromForm] IFormFile file)
        {
            if (file != null)
            {
                string path = Path.Combine(_env.WebRootPath,"Assets/Avatars", file.FileName);
                Stream stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                stream.Close();
                return true;
            }
            return false;
        }
    }

}