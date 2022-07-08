using BankEntityFrameWork.Repositories;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;

namespace ConsoleApp2.database
{
    public class FaqRepo : BaseRepository<Faq>
    {
        public override bool Create(Faq element)
        {
            Netflix.dataContext.Faqs.Add(element);
            return Netflix.Save();
        }

        public override List<Faq> FindAll()
        {
            return Netflix.dataContext.Faqs.ToList();
        }

        public override Faq FindById(int id)
        {
            return Netflix.dataContext.Faqs.Find(id);
        }

        public override bool Remove(int id)
        {
            Netflix.dataContext.Remove(Netflix.dataContext.Faqs.Single(a => a.Id == id));
            return Netflix.Save();
        }
    }
}
