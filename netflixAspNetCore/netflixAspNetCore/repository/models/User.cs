using netflixTestConsole.classes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("user")]
    public class User
    {
        [Required] public int Id { get; set; }
        [StringLength(Constants.userLastNameSize)] [Required] public string LastName { get; set; }
        [StringLength(Constants.userFirstNameSize)] [Required] public string FirstName { get; set; }
        [StringLength(Constants.userAvatarSize)][Required] public string Avatar { get; set; }
        //[Column("statut_id")] [Required] public int StatutId { get; set; }
        //[ForeignKey("StatutId")] public Statut Statut { get; set; }
        [StringLength(Constants.userMailSize)] [Required] public string Mail { get; set; }
        [StringLength(Constants.userPasswordSize)] [Required] public string Password { get; set; }
    }
}
