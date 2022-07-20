using Microsoft.AspNetCore.Mvc;
using netflixTestConsole.database.classes;
using Newtonsoft.Json;

namespace netflixAspNetCore.Controllers
{
    public class IsLogin : Controller
    {
        [HttpGet("isLogin")]
        public User Index()
        {
            User user = null;
            string isLogin = HttpContext.Session.GetString("isLogin");
            if(isLogin != null)
            {
                user = JsonConvert.DeserializeObject<User>(isLogin);
            }
            return user;
        }
    }
}
