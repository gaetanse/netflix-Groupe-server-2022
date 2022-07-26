using netflixTestConsole.database.classes;

namespace netflixAspNetCore.RecordDto
{
    public class Records
    {
        public record UserMailPasswordDTO(string mail, string password);
        public record UserTokenDTO(User user, string token);
    }
}
