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
    public class StatutRepo : BaseRepository<Statut>
    {
        DataContext _dataContext;

        public StatutRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public override bool Create(Statut element)
        {
            _dataContext.Statuts.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(Statut element)
        {
            _dataContext.Statuts.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override Statut FindById(int id)
        {
            return _dataContext.Statuts.Find(id);
        }

        public override List<Statut> FindAll()
        {
            return _dataContext.Statuts.ToList();
        }
    }
}
