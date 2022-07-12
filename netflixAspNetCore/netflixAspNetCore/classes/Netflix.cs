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
        public static FaqRepo FaqRepo { get; set; }
        public static ImageDataRepo ImageDataRepo { get; set; }
        public static TagRepo TagRepo { get; set; }
        public static StatutRepo StatutRepo { get; set; }
        public static RessourceRepo RessourceRepo { get; set; }
        public static void StartApp()
        {
            dataContext = new();
            UserRepo = new();
            FaqRepo = new();
            ImageDataRepo = new();
            TagRepo = new();
            StatutRepo = new();
            RessourceRepo = new();
        }

        public static bool Save()
        {
            return dataContext.SaveChanges() > 0 ? true : false;
        }

    }
}
