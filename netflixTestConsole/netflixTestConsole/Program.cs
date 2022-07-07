﻿using ConsoleApp2.database;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;

namespace NetflixServer
{
    public class Program
    {
        static void Main()
        {
            Netflix netflix = new Netflix();

            UserDb.Add("lastName","firstName",0,"test@gmail.com","123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");
            UserDb.Add("lastName", "firstName", 0, "test@gmail.com", "123");

            User user = UserDb.GetById(1);
            if (user is not null)
            {
                Console.Write(user.FirstName);
            }
            else
            {
                Console.WriteLine("error user is null");
            }

            List<User> users = UserDb.GetAll();
            if (users is not null)
            {
                Console.Write(users.ToString());
            }
            else
            {
                Console.WriteLine("error list of user is null");
            }

            /////
            ///
            FaqDb.Add("question", "response");
            FaqDb.Add("question", "response");
            FaqDb.Add("question", "response");

            Faq faq = FaqDb.GetById(1);
            if (faq is not null)
            {
                Console.Write(faq.Question);
            }
            else
            {
                Console.WriteLine("error user is null");
            }

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
