using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
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
        DataContext _dataContext;

        public UserRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
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

        /*public static User GetByLastName(string lastName)
        {
            //get all users by something
            User user = _dataContext.Users.FirstOrDefault(user => user.LastName == lastName);
            return user;
        }

        public static List<User> GetAllByLastName(string lastName)
        {
            //get all users by something
            List<User> users = _dataContext.Users.Where(users => users.LastName == lastName).ToList();
            return users;
        }*/

        public override bool Create(User element)
        {
            _dataContext.Users.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(User user)
        {
            _dataContext.Users.Remove(user);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override User FindById(int id)
        {
            return _dataContext.Users.Find(id);
        }
        public User Login(string mail, string password)
        {
            return _dataContext.Users.FirstOrDefault(user => user.Mail == mail && user.Password == password);
        }

        public int FindLastUserId()
        {
            return _dataContext.Users.Max(user => user.Id);
        }

        public override List<User> FindAll()
        {
            //verifier
            return _dataContext.Users.ToList();
        }
    }
}
