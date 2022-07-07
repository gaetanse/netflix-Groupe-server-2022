using CoursEntityFrameWorkCore;

namespace NetflixServer.Classes
{
    public class Netflix
    {
        public static DataContext dataContext;

        public Netflix()
        {
            dataContext = new DataContext();
        }

        public static bool Save()
        {
            return dataContext.SaveChanges() > 0 ? true : false;
        }

    }
}
