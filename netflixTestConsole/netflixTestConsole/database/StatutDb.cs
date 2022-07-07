using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class StatutDb
    {
        public static bool Add(string name, string description)
        {
            //register //check if != null

            Statut statut = new Statut()
            {
                Name = name
            };

            Netflix.dataContext.Statuts.Add(statut);
            return Netflix.Save();
        }
    }
}
