using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        public int RessourceId { get; set; }
    }
}
