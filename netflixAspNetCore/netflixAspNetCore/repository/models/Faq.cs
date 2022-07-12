using netflixTestConsole.classes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("faq")]
    public class Faq
    {
        [Required] public int Id { get; set; }
        [StringLength(Constants.faqQuestionSize)] [Required] public string Question { get; set; }
        [StringLength(Constants.faqResponseSize)] [Required] public string Response { get; set; }
    }
}
