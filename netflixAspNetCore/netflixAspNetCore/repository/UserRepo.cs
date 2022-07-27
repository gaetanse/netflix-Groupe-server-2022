using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
using Microsoft.EntityFrameworkCore;
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
            //todo: ban
            return false;
        }
        public User Login(string mail, string password)
        {
            return _dataContext.Users.FirstOrDefault(user => user.Mail == mail && user.Password == password);
        }

        public int FindLastUserId()
        {
            return _dataContext.Users.Max(user => user.Id);
        }

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

        public override List<User> FindAll()
        {
            return _dataContext.Users.ToList();
        }
    }
}
