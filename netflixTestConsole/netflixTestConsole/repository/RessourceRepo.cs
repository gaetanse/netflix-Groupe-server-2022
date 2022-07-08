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
    public class RessourceRepo : BaseRepository<Ressource>
    {
        public override bool Create(Ressource element)
        {
            throw new NotImplementedException();
        }

        public override List<Ressource> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<Ressource> FindAllBy(Predicate<Ressource> predicate)
        {
            throw new NotImplementedException();
        }

        public override Ressource FindBy(Predicate<Ressource> predicate)
        {
            throw new NotImplementedException();
        }

        public override Ressource FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Ressource element)
        {
            throw new NotImplementedException();
        }
    }
}
