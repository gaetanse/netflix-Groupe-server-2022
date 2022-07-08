using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database.classes
{
    [Table("ressource")]
    public class Ressource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column("category_id")] public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] public Category Category { get; set; }
        [Column("tag_id")] public int TagId { get; set; }
        [ForeignKey("TagId")] public List<Tag> Tags { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Trailer { get; set; }
        [Column("nb_episodes")] public int NbEpisodes { get; set; }
        [Column("nb_saisons")] public int NbSaisons { get; set; }
    }
}
