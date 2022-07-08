using BankEntityFrameWork.Repositories;
using NetflixServer.Classes;
using netflixTestConsole.database.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace netflixTestConsole.database
{
    public class ImageDataRepo : BaseRepository<ImageData>
    {
        public override bool Create(ImageData element)
        {
            Netflix.dataContext.ImageDatas.Add(element);
            return Netflix.Save();
        }

        public override List<ImageData> FindAll()
        {
            throw new NotImplementedException();
        }

        public override List<ImageData> FindAllBy(Predicate<ImageData> predicate)
        {
            throw new NotImplementedException();
        }

        public override ImageData FindBy(Predicate<ImageData> predicate)
        {
            throw new NotImplementedException();
        }

        public override ImageData FindById(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(ImageData element)
        {
            throw new NotImplementedException();
        }
    }
}
