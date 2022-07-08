using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.classes
{
    public static class Constants
    {
        public static Statut StatutUser { get; set; }
        public static Statut StatutAdmin { get; set; }
        public static Statut StatutCreator { get; set; }

        public const int categoryNameSize = 50;
        public const int categoryDescriptionSize = 200;

        public const int faqQuestionSize = 200;
        public const int faqResponseSize = 200;
        public static void Create()
        {
            StatutUser = new Statut() { Id = 0, Name = "user" };
            StatutAdmin = new Statut() { Id = 1, Name = "admin" };
            StatutCreator = new Statut() { Id = 2, Name = "creator" };
        }
    }
}
