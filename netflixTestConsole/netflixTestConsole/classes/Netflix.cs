using CoursEntityFrameWorkCore;
using NetflixServerConsoleTest.classes;

namespace NetflixServer.Classes
{
    public class Netflix
    {
        public static DataContext dataContext;

        public Netflix()
        {
            dataContext = new DataContext();
        }

    }
}
