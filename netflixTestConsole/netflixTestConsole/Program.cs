using ConsoleApp2.database;
using NetflixServer.Classes;
using netflixTestConsole.classes;
using netflixTestConsole.database;
using netflixTestConsole.database.classes;

namespace NetflixServer
{
    public class Program
    {
        static void Main()
        {
            Netflix.StartApp();

            Statut statutUser = Netflix.StatutRepo.FindById(Constants.statutUserNumber);
            Statut statutAdmin = Netflix.StatutRepo.FindById(Constants.statutAdminNumber);
            Statut statutCreator = Netflix.StatutRepo.FindById(Constants.statutCreatorNumber);

            if (Netflix.UserRepo.Create(new()
            {
                LastName = "jetaicreer",
                FirstName = "fisrtnameaaaaaaa",
                StatutId = statutUser.Id,
                Statut = statutUser,
                Mail = "test@gmail.com",
                Password = "123"
            })){
                Console.WriteLine("user create");
            }
            else
            {
                Console.WriteLine("user cannot be create");
            }

            /*if (Netflix.UserRepo.Remove(8)){
                Console.WriteLine("suppression ok");
            }
            else
            {
                Console.WriteLine("suppression pas ok");
            }*/

            /*Console.WriteLine("user 1 : "+Netflix.UserRepo.FindById(1).Statut.Name);

            if (Netflix.UserRepo.Create(new()
            {
                LastName = "admin",
                FirstName = "admin",
                StatutId = statutAdmin.Id,
                Statut = statutAdmin,
                Mail = "test@gmail.com",
                Password = "123"
            }))
            {
                Console.WriteLine("admin create");
            }
            else
            {
                Console.WriteLine("admin cannot be create");
            }

            if (Netflix.UserRepo.Create(new()
            {
                LastName = "creator",
                FirstName = "creator",
                StatutId = statutCreator.Id,
                Statut = statutCreator,
                Mail = "test@gmail.com",
                Password = "123"
            }))
            {
                Console.WriteLine("creator create");
            }
            else
            {
                Console.WriteLine("creator cannot be create");
            }*/

            Faq faq = new() { 
                Question = "la question", 
                Response = "La reponse" 
            };

            if (Netflix.FaqRepo.Create(faq))
            {
                Console.WriteLine("faq create");
            }
            else
            {
                Console.WriteLine("faq cannot be create");
            }

            Category category = new Category()
            {
                Id = 0,
                Name = "name",
                Description = "description"
            };

            Tag tag = new()
            {
                Id = 0,
                Name = "name",
                Description = "description"
            };

            List<Tag> tags = new List<Tag>()
            {
                tag,
                tag,
                tag,
                tag
            };

            Ressource ressource = new()
            {
                Id = 0,
                Title = "title",
                CategoryId = category.Id,
                Category = category,
                TagId = tag.Id,
                Tags = tags,
                Description = "description",
                Content = "content",
                Trailer = "trailer",
                NbEpisodes = 50,
                NbSaisons = 3
            };

            ImageData imageData = new()
            {

                Url = "url",
                Type = "type",
                RessourceId = ressource.Id,
                Ressource = ressource
            };

            if (Netflix.ImageDataRepo.Create(imageData))
            {
                Console.WriteLine("imageData create");
            }
            else
            {
                Console.WriteLine("imageData cannot be create");
            }

            /*UserRepo.Add("lastName","firstName",0,"test@gmail.com","123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserRepo.Add("lastName", "firstName", 0, "test@gmail.com", "123");

            User user = UserRepo.GetById(1);
            if (user is not null)
            {
                Console.Write(user.FirstName);
            }
            else
            {
                Console.WriteLine("error user is null");
            }

            List<User> users = UserRepo.GetAll();
            if (users is not null)
            {
                Console.Write(users.ToString());
            }
            else
            {
                Console.WriteLine("error list of user is null");
            }*/

            /////
            ///
            /*FaqRepo.Add("question", "response");
            FaqRepo.Add("question", "response");
            FaqRepo.Add("question", "response");

            Faq faq = FaqRepo.GetById(1);
            if (faq is not null)
            {
                Console.Write(faq.Question);
            }
            else
            {
                Console.WriteLine("error user is null");
            }*/

            /*if(CategoryRepo.Add("test", "test description"))
            {
                Console.WriteLine("création d'une catégorie");
            }
            else
            {
                Console.WriteLine("impossible de creer une catégorie");
            }*/

            //Tag tag = new Tag() { Name = "nom", Description = "description du tag" };

            /*if (Netflix.TagRepo.Create(tag))
            {
                Console.WriteLine("création d'un tag");
            }
            else
            {
                Console.WriteLine("création d'un tag");
            }*/

            //StatutRepo.Add("name", "description");

            //RessourceRepo.Add("title",0,new List<Tag>() { tag, tag, tag, tag },"description","content","trailer",50,5);

            //ImageDataRepo.Add("url", "type", 0);

            //List<User> users = new List<User>();
            //users = netflix.RequestGetAllUser();

            //Console.WriteLine(SecurityPassword.Hash("mdp"));

            //Personne p = new Personne()
            //{
            //    Name = "toto",
            //    Age = 30
            //};
            //Enregistrer la personne dans la table
            //d.Personnes.Add(p);
            //d.SaveChanges();

            //Pour récupérer les données

            //List<Personne> list = d.Personnes.ToList();

            //Console.WriteLine(list.Count);

            //Personne p = d.Personnes.Find(1);
            //Personne p = d.Personnes.FirstOrDefault(p => p.Name == "toto");
            //List<Personne> list = d.Personnes.Where(p => p.Name == "toto").ToList();

            //p.Name = "tata";

            //d.SaveChanges();

            //Console.WriteLine(p);
        }

    }
}
