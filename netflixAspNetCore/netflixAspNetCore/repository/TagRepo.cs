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

        /*public override bool Create(Tag element)
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

        public override bool Remove(Tag tag)
        {
            Netflix.dataContext.Tags.Remove(tag);
            return Netflix.Save();
        }*/
        public override bool Create(Tag element)
        {
            throw new NotImplementedException();
        }

        public override List<Tag> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Tag FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(Tag element)
        {
            throw new NotImplementedException();
        }
    }
}
