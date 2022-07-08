using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    [Table("statut")]
    public class Statut
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
