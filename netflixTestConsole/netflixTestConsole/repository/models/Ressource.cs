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
    [Table("ressource")]
    public class Ressource
    {
        [Required] public int Id { get; set; }
        [StringLength(Constants.ressourceTitleSize)] [Required] public string Title { get; set; }
        [Column("category_id")] [Required] public int CategoryId { get; set; }
        [ForeignKey("CategoryId")] public Category Category { get; set; }
        [Column("tag_id")] [Required] public int TagId { get; set; }
        [ForeignKey("TagId")] public List<Tag> Tags { get; set; }
        [StringLength(Constants.ressourceDescriptionSize)] [Required] public string Description { get; set; }
        [StringLength(Constants.ressourceContentSize)] [Required] public string Content { get; set; }
        [StringLength(Constants.ressourceTrailerSize)] [Required] public string Trailer { get; set; }
        [Column("nb_episodes")] [Required] public int NbEpisodes { get; set; }
        [Column("nb_saisons")] [Required] public int NbSaisons { get; set; }
    }
}
