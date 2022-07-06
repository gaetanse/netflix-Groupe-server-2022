using NetflixServer.Classes;

namespace NetflixServer
{
    public class Program
    {
        static void Main()
        {
            Netflix netflix = new Netflix();
            Console.WriteLine(SecurityPassword.Hash("mdp"));
        }

    }
}
