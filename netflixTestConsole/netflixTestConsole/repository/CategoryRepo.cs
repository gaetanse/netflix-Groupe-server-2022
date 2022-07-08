﻿using BankEntityFrameWork.Repositories;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netflixTestConsole.database
{
    public class CategoryRepo : BaseRepository<Category>
    {
        public override bool Create(Category element)
        {
            throw new NotImplementedException();
        }

        public override List<Category> FindAll()
        {
            return Netflix.dataContext.Categorys.ToList();
        }

        public override Category FindById(int id)
        {
            return Netflix.dataContext.Categorys.Find(id);
        }

        public override bool Remove(int id)
        {
            Netflix.dataContext.Remove(Netflix.dataContext.Categorys.Single(a => a.Id == id));
            return Netflix.Save();
        }
    }
}
