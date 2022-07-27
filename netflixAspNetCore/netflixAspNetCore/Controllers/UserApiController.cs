using BankEntityFrameWork.Repositories;
using ConsoleApp2.database;
using CoursEntityFrameWorkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using netflixAspNetCore.Services;
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
        private BaseRepository<User> _baseRepositoryUser;
        private UserRepo _userRepo;
        private DataContext _dataContext;
        public UserApiController(TokenService tokenService,BaseRepository<User> baseRepositoryUser, UserRepo userRepo, DataContext dataContext)
        {
            _tokenService = tokenService;
            _baseRepositoryUser = baseRepositoryUser;
            _userRepo = userRepo;
            _dataContext = dataContext;
        }

        [HttpGet("token")]
        //[AllowAnonymous]
        public IActionResult GetToken(string mail, string password)
        {
            string token = _tokenService.Authenticate(mail, password);
            User user = _userRepo.Login(mail, password);
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

        [HttpGet("statut")]
        //[Authorize]
        public IActionResult GetStatut()
        {
            //TODO
            return NotFound();
        }

        //ajouter get user avec un id
    }

}