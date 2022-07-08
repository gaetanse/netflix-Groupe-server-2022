using netflixTestConsole.classes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("category")]
    public class Category
    {
        [Required] public int Id { get; set; }
        [StringLength(Constants.categoryNameSize)] [Required] public string Name { get; set; }
        [StringLength(Constants.categoryDescriptionSize)] [Required] public string Description { get; set; }
    }
}
