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
    public class CategoryRepo : BaseRepository<Category>
    {
        DataContext _dataContext;

        public CategoryRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public override bool Create(Category element)
        {
            _dataContext.Categorys.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(Category element)
        {
            _dataContext.Categorys.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override Category FindById(int id)
        {
            return _dataContext.Categorys.Find(id);
        }

        public override List<Category> FindAll()
        {
            return _dataContext.Categorys.ToList();
        }
    }
}
