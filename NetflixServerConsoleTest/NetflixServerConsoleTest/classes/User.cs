namespace NetflixServerConsoleTest.classes
{
    public class User
    {
        int Id { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        int NumberStatut { get; set; }
        string Mail { get; set; }
        string Password { get; set; }
        public User(int id, string lastName, string firstName, int numberStatus, string mail, string password)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            NumberStatut = numberStatus;
            Mail = mail;
            Password = password;
        }
    }
}
