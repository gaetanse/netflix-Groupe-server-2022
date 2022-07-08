using BankEntityFrameWork.Repositories;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.database
{
    public class UserRepo : BaseRepository<User>
    {

        public static bool Login(string mail, string password)
        {
            //login with sha256
            return false;
        }

        public static bool BanUser(int id, bool newBan)
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

        public static User GetById(int id)
        {
            //get user with a id
            return Netflix.dataContext.Users.Find(id);
        }

        public static List<User> GetAll()
        {
            //get all users
            List<User> list = Netflix.dataContext.Users.ToList();
            return list;
        }

        public static User GetByLastName(string lastName)
        {
            //get all users by something
            User user = Netflix.dataContext.Users.FirstOrDefault(user => user.LastName == lastName);
            return user;
        }

        public static List<User> GetAllByLastName(string lastName)
        {
            //get all users by something
            List<User> users = Netflix.dataContext.Users.Where(users => users.LastName == lastName).ToList();
            return users;
        }

        public override bool Create(User element)
        {
            Netflix.dataContext.Users.Add(element);
            return Netflix.Save();
        }

        public override bool Update(User element)
        {
            throw new NotImplementedException();
        }

        public override List<User> FindAllBy(Predicate<User> predicate)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(int id)
        {
            Netflix.dataContext.Remove(Netflix.dataContext.Users.Single(a => a.Id == id));
            return Netflix.Save();
        }

        public override User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override User FindBy(Predicate<User> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<User> FindAll()
        {
            throw new NotImplementedException();
        }
    }
}
