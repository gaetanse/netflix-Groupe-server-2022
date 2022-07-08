using BankEntityFrameWork.Repositories;
using NetflixServer.Classes;
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
        public override bool Create(Statut element)
        {
            throw new NotImplementedException();
        }

        public override List<Statut> FindAll()
        {
            return Netflix.dataContext.Statuts.ToList();
        }

        //public override List<Statut> FindAllBy(Predicate<Statut> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        //public override Statut FindBy(Predicate<Statut> predicate)
        //{
        //    throw new NotImplementedException();
        //}

        public override Statut FindById(int id)
        {
            return Netflix.dataContext.Statuts.Find(id);
        }

        public override bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        //public override bool Update(Statut element)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
