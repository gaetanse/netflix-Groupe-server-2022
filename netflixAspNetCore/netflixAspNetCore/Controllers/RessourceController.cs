using Microsoft.AspNetCore.Mvc;

namespace netflixAspNetCore.Controllers
{
    public class RessourceController : Controller
    {
        [HttpPost("ressource")]
        public bool Index([FromForm] IFormFile file)
        {
            string name = file.FileName;
            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                FileStream fileStream = new FileStream("Assets/Ressources/" + name, FileMode.Create, FileAccess.Write);
                fileStream.Write(memoryStream.ToArray());
                fileStream.Dispose();
                return true;
            }
        }
    }
}
