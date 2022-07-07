using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    public class Ressource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public List<Tag> Tags { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Trailer { get; set; }
        public int NbEpisodes { get; set; }
        public int NbSaisons { get; set; }
    }
}
