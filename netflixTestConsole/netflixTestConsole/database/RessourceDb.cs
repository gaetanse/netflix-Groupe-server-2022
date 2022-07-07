using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class RessourceDb
    {
        public static bool Add(string title, int categoryId, List<Tag>tags, string description, string content, string trailer, int nbEpisodes, int nbSaisons)
        {
            //register //check if != null

            Ressource ressource = new Ressource()
            {
                Title = title,
                CategoryId = categoryId,
                Tags = tags,
                Description = description,
                Content = content,
                Trailer = trailer,
                NbEpisodes = nbEpisodes,
                NbSaisons = nbSaisons
            };

            Netflix.dataContext.Ressources.Add(ressource);
            return Netflix.Save();
        }
    }
}
