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
            throw new NotImplementedException();
        }

        public override List<Tag> FindAllBy(Predicate<Tag> predicate)
        {
            throw new NotImplementedException();
        }

        public override Tag FindBy(Predicate<Tag> predicate)
        {
            throw new NotImplementedException();
        }

        public override Tag FindById(int id)
        {
            return Netflix.dataContext.Tags.Find(id);
        }

        public override bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Tag element)
        {
            throw new NotImplementedException();
        }
    }
}
