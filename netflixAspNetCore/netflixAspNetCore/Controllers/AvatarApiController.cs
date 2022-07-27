using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using netflixTestConsole.database.classes;

namespace netflixAspNetCore.Controllers
{
    [Route("api/v1/avatar")]
    [ApiController]
    [EnableCors("react")]
    public class AvatarApiController : ControllerBase
    {

        private IWebHostEnvironment _env;

        public AvatarApiController(IWebHostEnvironment env)
        {
            _env = env;
        }

        // [AllowAnonymous] permettre d'acceder sans authentification

        public class ThingNeedForNowDTO
        {
            public int id;
            public string avatar;
        }

        [HttpPost]
        [Authorize]
        //public bool Index([FromForm] IFormFile file)
        public IActionResult Post([FromForm] IFormFile file)
        {
            if (file != null)
            {
                //creer un dossier si il n'existe pas et le mettre dedans 
                string path = Path.Combine(_env.WebRootPath, "Assets/Avatars", file.FileName);
                Stream stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                stream.Close();
                return Ok();
            }
            return NotFound();
        }

        //adapter en controller

        /*app.MapGet("/user/setavatar", (int id, string avatar) => {
            User user = Netflix.UserRepo.FindById(id);
                Console.WriteLine(avatar);
            //statut vide ???
            if (user != null)
            {
                user.Avatar = avatar;
                Console.WriteLine(avatar);
                Netflix.Save();
                return user;
            }
            return null;
        });*/
    }

}