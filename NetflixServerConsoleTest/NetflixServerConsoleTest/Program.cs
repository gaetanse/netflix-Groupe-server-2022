using NetflixServer.Classes;
using NetflixServerConsoleTest.classes;

namespace NetflixServer
{
    public class Program
    {
        static void Main()
        {
            Netflix netflix = new Netflix();

            netflix.RequestRegister("lastName","firstName",0,"test@gmail.com","123");
            netflix.RequestRegister("lastName", "firstName", 0, "test@gmail.com", "123");
            User userTest = netflix.RequestGetUser(0);

            List<User> users = new List<User>();
            users = netflix.RequestGetAllUser();

            Console.WriteLine(SecurityPassword.Hash("mdp"));
        }

    }
}
