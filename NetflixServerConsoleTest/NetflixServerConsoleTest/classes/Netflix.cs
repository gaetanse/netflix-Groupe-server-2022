using NetflixServerConsoleTest.classes;

namespace NetflixServer.Classes
{
    public class Netflix
    {
        public bool RequestRegister(string lastName, string firstName, int numberStatus, string mail, string password)
        {
            //register
            return false;
        }

        public bool RequestLogin(string mail, string password)
        {
            //login with sha256
            return false;
        }

        public bool RequestBanUser(int id, bool newBan)
        {
            //ban a user with newBan with a id
            return false;
        }

        /*public bool RequestGetLostPassword(string mail)
        {
            //get a new password by mail
            return false;
        }*/

        /*public bool RequestIsLogin(string mail, string password)
        {
            //test if is login
            return false;
        }*/

        public User RequestGetUser(int id)
        {
            //get user with a id
            return null;
        }

        public List<User> RequestGetAllUser()
        {
            //get all users
            return null;
        }

        public bool RequestRemoveUser(int id)
        {
            //remove a user with a id
            return false;
        }

    }
}
