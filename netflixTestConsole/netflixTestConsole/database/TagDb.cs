using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class TagDb
    {
        public static bool Add(string name, string description)
        {
            //register //check if != null

            Tag faq = new Tag()
            {
                Name = name,
                Description = description
            };

            Netflix.dataContext.Tags.Add(faq);
            if (Netflix.dataContext.SaveChanges() != 0) return true;
            return false;
        }
    }
}
