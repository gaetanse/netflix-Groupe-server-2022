using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using netflixAspNetCore.Services;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System.Security.Claims;
using static netflixAspNetCore.RecordDto.Records;

namespace netflixAspNetCore.Controllers
{
    [Route("api/v1/user")]
    [ApiController]
    [Authorize]
    public class UserApiController : ControllerBase
    {
        private TokenService _tokenService;
        public UserApiController(TokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet("token")]
        [AllowAnonymous]
        public IActionResult GetToken(string mail, string password)
        {
            string token = _tokenService.Authenticate(mail, password);
            User user = Netflix.UserRepo.Login(mail, password);
            return token != null && user != null ? Ok(new UserTokenDTO(user,token)) : NotFound(); 
        }

        [HttpGet("role")]
        public IActionResult GetRole()
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)HttpContext.User.Identity;
            if(claimsIdentity != null)
            {
                string role = claimsIdentity.FindFirst("statut").Value;
                return Ok(role);
            }
            else
            {
                return NotFound();
            }
        }

        //ajouter get user avec un id
    }

}