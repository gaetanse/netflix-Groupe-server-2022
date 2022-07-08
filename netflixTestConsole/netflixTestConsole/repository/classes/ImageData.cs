using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("imageData")]
    public class ImageData
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Type { get; set; }
        [Column("ressource_id")] public int RessourceId { get; set; }
        [ForeignKey("RessourceId")] public Ressource Ressource { get; set; }
    }
}
