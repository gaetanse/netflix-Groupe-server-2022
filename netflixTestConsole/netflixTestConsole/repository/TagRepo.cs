using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class TagRepo : BaseRepository<Tag>
    {
        public TagRepo() : base(){ }

        public override bool Create(Tag element)
        {
            Netflix.dataContext.Tags.Add(element);
            return Netflix.Save();
        }

        public override List<Tag> FindAll()
        {
            return Netflix.dataContext.Tags.ToList();
        }

        public override Tag FindById(int id)
        {
            return Netflix.dataContext.Tags.Find(id);
        }

        public override bool Remove(int id)
        {
            Netflix.dataContext.Remove(Netflix.dataContext.Tags.Single(a => a.Id == id));
            return Netflix.Save();
        }
    }
}
