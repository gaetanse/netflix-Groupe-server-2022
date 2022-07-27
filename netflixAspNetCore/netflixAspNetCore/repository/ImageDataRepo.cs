using BankEntityFrameWork.Repositories;
using CoursEntityFrameWorkCore;
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
        DataContext _dataContext;

        public ImageDataRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public override bool Create(ImageData element)
        {
            _dataContext.ImageDatas.Add(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }

        public override bool Remove(ImageData element)
        {
            _dataContext.ImageDatas.Remove(element);
            return _dataContext.SaveChanges() > 0 ? true : false;
        }
        public override ImageData FindById(int id)
        {
            return _dataContext.ImageDatas.Find(id);
        }

        public override List<ImageData> FindAll()
        {
            return _dataContext.ImageDatas.ToList();
        }
    }
}
