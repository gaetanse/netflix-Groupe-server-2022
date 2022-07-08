using ConsoleApp2.database;
using CoursEntityFrameWorkCore;
using netflixTestConsole.classes;
using netflixTestConsole.database;

namespace NetflixServer.Classes
{
    public static class Netflix
    {
        public static DataContext dataContext;
        public static UserRepo UserRepo { get; set; }
        public static void StartApp()
        {
            dataContext = new DataContext();
            Constants.Create();
            UserRepo = new UserRepo();
        }

        public static bool Save()
        {
            return dataContext.SaveChanges() > 0 ? true : false;
        }

    }
}
