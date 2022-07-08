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
            //use include
            return Netflix.dataContext.Ressources.ToList();
        }

        public override Ressource FindById(int id)
        {
            //use include
            return Netflix.dataContext.Ressources.Find(id);
        }

        public override bool Remove(int id)
        {
            Netflix.dataContext.Remove(Netflix.dataContext.Ressources.Single(a => a.Id == id));
            return Netflix.Save();
        }
    }
}
