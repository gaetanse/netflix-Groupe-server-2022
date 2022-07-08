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

        public override Faq Find(Predicate<Faq> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Faq> FindAll(Predicate<Faq> predicate)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Faq element)
        {
            throw new NotImplementedException();
        }
    }
}
