﻿using DemoAspnetMvcCore.Models;
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

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }

            return View(filme);
        }
    }
}
