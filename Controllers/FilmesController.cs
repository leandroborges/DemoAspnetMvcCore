using Microsoft.AspNetCore.Mvc;

namespace DemoAspnetMvcCore.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public  IActionResult Adicionar()
        {
            return View();
        }
    }
}
