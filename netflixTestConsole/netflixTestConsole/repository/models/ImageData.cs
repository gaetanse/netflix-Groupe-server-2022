using netflixTestConsole.classes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("imageData")]
    public class ImageData
    {
        [Required] public int Id { get; set; }
        [StringLength(Constants.imageDataUrlSize)] [Required] public string Url { get; set; }
        [StringLength(Constants.imageDataTypeSize)] [Required] public string Type { get; set; }
        [Column("ressource_id")] [Required] public int RessourceId { get; set; }
        [ForeignKey("RessourceId")] public Ressource Ressource { get; set; }
    }
}
