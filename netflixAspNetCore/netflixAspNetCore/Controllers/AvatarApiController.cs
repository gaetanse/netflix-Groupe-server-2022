using BankEntityFrameWork.Repositories;
using ConsoleApp2.database;
using CoursEntityFrameWorkCore;
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
        private UserRepo _userRepo;
        private DataContext _dataContext;

        private IWebHostEnvironment _env;

        public AvatarApiController(IWebHostEnvironment env,UserRepo userRepo, DataContext dataContext)
        {
            _env = env;
            _userRepo = userRepo;
            _dataContext = dataContext;
        }

        public class ThingNeedForNowDTO
        {
            public int id;
            public string avatar;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post([FromForm] IFormFile file, int id, string avatar)
        {
            if (file != null)
            {
                //creer un dossier si il n'existe pas et le mettre dedans 
                string path = Path.Combine(_env.WebRootPath, "Assets/Avatars", file.FileName);
                Stream stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                stream.Close();
                User user = _userRepo.FindById(id);
                if (user != null)
                {
                    user.Avatar = avatar;
                    _dataContext.SaveChanges();
                    //return only the avatar of the user
                    return Ok(user);
                }
            }
            return NotFound();
        }
    }

}