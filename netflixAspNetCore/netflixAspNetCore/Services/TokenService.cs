using BankEntityFrameWork.Repositories;
using ConsoleApp2.database;
using Microsoft.IdentityModel.Tokens;
using netflixTestConsole.database.classes;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace netflixAspNetCore.Services
{
    public class TokenService
    {
        UserRepo _repositoryUser;
        public TokenService(UserRepo repositoryUser)
        {
            _repositoryUser = repositoryUser;
        }
        public string Authenticate(string mail, string password)
        {
            User user = _repositoryUser.Login(mail, password);
            if (user != null)
            {

                //get statut if role admin if user

                /*Claim claim = null;

                Statut statut = Netflix.StatutRepo.FindByUserId(user.Id);
                if (statut != null)
                {
                    claim = new Claim("statut", statut.Name);
                }*/

                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
                {
                    Expires = DateTime.Now.AddDays(2),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("bonjour je suis la chaine de crypto")), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = "m2i",
                    Audience = "m2i",
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("statut", "test")
                    })
                };
                SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            return null;
        }
    }
}
