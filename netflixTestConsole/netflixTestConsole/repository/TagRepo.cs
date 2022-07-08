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
            /*Netflix.dataContext.Tags.Add(element);
            return Netflix.Save();*/
            throw new NotImplementedException();
        }

        public override Tag Find(Predicate<Tag> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Tag> FindAll(Predicate<Tag> predicate)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Tag element)
        {
            throw new NotImplementedException();
        }
    }
}
