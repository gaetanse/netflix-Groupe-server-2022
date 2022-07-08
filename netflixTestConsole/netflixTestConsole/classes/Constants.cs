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

        public const ushort categoryNameSize = 50;
        public const ushort categoryDescriptionSize = 200;

        public const ushort faqQuestionSize = 200;
        public const ushort faqResponseSize = 200;

        public const ushort imageDataUrlSize = 200;
        public const ushort imageDataTypeSize = 200;

        public const ushort ressourceTitleSize = 50;
        public const ushort ressourceDescriptionSize = 200;
        public const ushort ressourceContentSize = 200;
        public const ushort ressourceTrailerSize = 200;

        public const ushort statutNameSize = 200;

        public const ushort tagNameSize = 50;
        public const ushort tagDescriptionSize = 200;

        public const ushort userLastNameSize = 50;
        public const ushort userFirstNameSize = 50;
        public const ushort userMailSize = 200;
        public const ushort userPasswordSize = 200;
        public static void Create()
        {
            StatutUser = new Statut() { Id = 0, Name = "user" };
            StatutAdmin = new Statut() { Id = 1, Name = "admin" };
            StatutCreator = new Statut() { Id = 2, Name = "creator" };
        }
    }
}
