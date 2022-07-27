using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class RessourceRepo : BaseRepository<Ressource>
    {
        DataContext _dataContext;

        public RessourceRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public override bool Create(Ressource element)
        {
            _dataContext.Ressources.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(Ressource element)
        {
            _dataContext.Ressources.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override Ressource FindById(int id)
        {
            return _dataContext.Ressources.Find(id);
        }

        public override List<Ressource> FindAll()
        {
            return _dataContext.Ressources.ToList();
        }
    }
}
