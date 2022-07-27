using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
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
    [EnableCors("react")]
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
        [Authorize]
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

        [HttpPatch("setAvatar")]
        [Authorize]
        public IActionResult setAvatar(int id, string avatar)
        {
            User user = Netflix.UserRepo.FindById(id);
            if (user != null)
            {
                user.Avatar = avatar;
                Netflix.Save();
                //return only the avatar of the user
                return Ok(user);
            }
            return NotFound();
        }

        //ajouter get user avec un id
    }

}