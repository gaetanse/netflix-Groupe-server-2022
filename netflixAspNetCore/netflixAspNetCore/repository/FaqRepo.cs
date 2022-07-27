using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
using netflixTestConsole.database.classes;

namespace ConsoleApp2.database
{
    public class FaqRepo : BaseRepository<Faq>
    {
        DataContext _dataContext;

        public FaqRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public override bool Create(Faq element)
        {
            _dataContext.Faqs.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(Faq element)
        {
            _dataContext.Faqs.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override Faq FindById(int id)
        {
            return _dataContext.Faqs.Find(id);
        }

        public override List<Faq> FindAll()
        {
            return _dataContext.Faqs.ToList();
        }
    }
}
