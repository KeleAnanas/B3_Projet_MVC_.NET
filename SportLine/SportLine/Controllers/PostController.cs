using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportLine.Models;

namespace SportLine.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Posts()
        {
            var liste = new List<Post>()
            {

            };
            // Remplir
            return View(liste);
        }
    }
}