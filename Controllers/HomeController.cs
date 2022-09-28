using DemoAspnetMvcCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DemoAspnetMvcCore.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id}")]
        [Route("pagina-inicial/{id}/{categoria?}")]
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            //return View();

            //return Json("{'nome':'Leandro'}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"c:\arquivo.text");
            //var fileName = "Leandro.txt";
            //return File(fileBytes, MediaTypeNames.Application.Octet, fileName);

            return Content("Conteúdo teste");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
