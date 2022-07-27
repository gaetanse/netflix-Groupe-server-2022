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
    [Route("api/v1/faq")]
    [ApiController]
    [EnableCors("react")]
    public class FaqController : ControllerBase
    {
        private TokenService _tokenService;
        private BaseRepository<User> _baseRepositoryUser;
        private BaseRepository<Faq> _faqController;
        private UserRepo _userRepo;
        private DataContext _dataContext;
        public FaqController(TokenService tokenService, BaseRepository<User> baseRepositoryUser, UserRepo userRepo, DataContext dataContext, BaseRepository<Faq> faqController)
        {
            _tokenService = tokenService;
            _baseRepositoryUser = baseRepositoryUser;
            _userRepo = userRepo;
            _dataContext = dataContext;
            _faqController = faqController;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Get()
        {
            List<Faq> faqs = _faqController.FindAll().ToList();
            if (faqs != null)
            {
                return Ok(faqs);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        [AllowAnonymous] //acces seulement pour un admin
        public IActionResult Post(string question, string response)
        {
            if(_faqController.Create(new Faq()
            {
                Question = question,
                Response = response
            }))
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        /*[HttpGet("token")]
        [AllowAnonymous]
        public IActionResult GetToken(string mail, string password)
        {
            string token = _tokenService.Authenticate(mail, password);
            User user = _userRepo.Login(mail, password);
            return token != null && user != null ? Ok(new UserTokenDTO(user, token)) : NotFound();
        }

        [HttpGet("role")]
        [Authorize]
        public IActionResult GetRole()
        {
            ClaimsIdentity claimsIdentity = (ClaimsIdentity)HttpContext.User.Identity;
            if (claimsIdentity != null)
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
        [Authorize]
        public IActionResult GetStatut()
        {
            //TODO
            return NotFound();
        }

        [HttpPatch("setAvatar")]
        [Authorize]
        public IActionResult setAvatar(int id, string avatar)
        {
            User user = _baseRepositoryUser.FindById(id);
            if (user != null)
            {
                user.Avatar = avatar;
                _dataContext.SaveChanges();
                //return only the avatar of the user
                return Ok(user);
            }
            return NotFound();
        }*/

        //ajouter get user avec un id
    }

}