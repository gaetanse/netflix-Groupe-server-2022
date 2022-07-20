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
            Netflix.dataContext.Statuts.Add(element);
            return Netflix.Save();
        }

        public override List<Statut> FindAll()
        {
            return Netflix.dataContext.Statuts.ToList();
        }

        public override Statut FindById(int id)
        {
            return Netflix.dataContext.Statuts.Find(id);
        }

        public Statut FindByUserId(int id)
        {
            return Netflix.dataContext.Statuts.FirstOrDefault(statut => statut.UserId == id);
        }

        public override bool Remove(Statut statut)
        {
            Netflix.dataContext.Statuts.Remove(statut);
            return Netflix.Save();
        }
    }
}
