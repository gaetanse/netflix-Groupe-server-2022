using Microsoft.AspNetCore.Mvc;
using netflixAspNetCore.Services;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using static netflixAspNetCore.RecordDto.Records;

namespace netflixAspNetCore.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    //interdire a tout le controller 
    public class UserApiController : ControllerBase
    {
        private TokenService _tokenService;
        public UserApiController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet("token")]
        public IActionResult GetToken(string mail, string password)
        {
            string token = _tokenService.Authenticate(mail, password);
            User user = Netflix.UserRepo.Login(mail, password);
            return token != null && user != null ? Ok(new UserTokenDTO(user,token)) : NotFound(); 
        }

        //ajouter get user avec un id
    }

}