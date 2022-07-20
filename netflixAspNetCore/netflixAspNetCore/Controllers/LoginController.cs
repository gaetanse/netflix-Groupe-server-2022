using Microsoft.AspNetCore.Mvc;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using Newtonsoft.Json;

namespace netflixAspNetCore.Controllers
{
    public class loginController : Controller
    {

        [HttpGet("login")]
        public User Index(string mail, string password)
        {
            User user = Netflix.UserRepo.Login(mail, password);
            return user;
        }
    }

}