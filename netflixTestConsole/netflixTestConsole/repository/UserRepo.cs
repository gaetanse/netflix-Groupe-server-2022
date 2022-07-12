using BankEntityFrameWork.Repositories;
using Microsoft.EntityFrameworkCore;
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

        public User Login(string mail, string password)
        {
            return Netflix.dataContext.Users.Include(user => user.Statut).FirstOrDefault(user => user.Mail == mail && user.Password == password);
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
            Netflix.dataContext.SaveChanges();
            return true;
            //return Netflix.Save();
        }

        public override bool Remove(User user)
        {
            Netflix.dataContext.Users.Remove(user);
            return Netflix.Save();
        }
        public override User FindById(int id)
        {
            return Netflix.dataContext.Users.Find(id);
        }

        public override List<User> FindAll()
        {
            //verifier
            return Netflix.dataContext.Users.Include(u => u.Statut).ToList();
        }
    }
}
