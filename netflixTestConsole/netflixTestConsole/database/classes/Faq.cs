using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    public class Faq
    {

        // OBJECT object Personne { get; set; }
        // [ForeignKey("Personne")]
        // 
        public int Id { get; set; }
        public string Question { get; set; }
        public string Response { get; set; }
    }
}
