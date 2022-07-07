using ConsoleApp2.classes;
using NetflixServer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.database
{
    public static class FaqDb
    {
        public static bool Add(string question, string response)
        {
            //register //check if != null

            Faq faq = new Faq()
            {
                Question = question,
                Response = response
            };

            Netflix.dataContext.Faqs.Add(faq);
            if (Netflix.dataContext.SaveChanges() != 0) return true;
            return false;
        }
        public static Faq GetById(int id)
        {
            //get user with a id
            return Netflix.dataContext.Faqs.Find(id);
        }
    }
}
