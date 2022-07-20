using netflixTestConsole.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    [Table("statut")]
    public class Statut
    {
        [Required] public int Id { get; set; }
        [Required] public int StatutId { get; set; }
        [Required] public int UserId { get; set; }
        [StringLength(Constants.statutNameSize)] [Required] public string Name { get; set; }
        [StringLength(Constants.statutDescriptionSize)] [Required] public string Description { get; set; }
    }
}
