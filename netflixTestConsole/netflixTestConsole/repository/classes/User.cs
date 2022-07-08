using System.ComponentModel.DataAnnotations.Schema;

namespace netflixTestConsole.database.classes
{
    [Table("user")]
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        [Column("statut_id")] public int StatutId { get; set; }
        [ForeignKey("StatutId")] public Statut Statut { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
    }
}
