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
    public class TagRepo : BaseRepository<Tag>
    {
        DataContext _dataContext;

        public TagRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public override bool Create(Tag element)
        {
            _dataContext.Tags.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(Tag element)
        {
            _dataContext.Tags.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override Tag FindById(int id)
        {
            return _dataContext.Tags.Find(id);
        }

        public override List<Tag> FindAll()
        {
            return _dataContext.Tags.ToList();
        }
    }
}
