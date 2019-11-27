using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportLine.Models;

namespace SportLine.Controllers
{
    public class PostController : Controller
    {
        public IActionResult PostListe()
        {
            var liste = new List<Post>()
            {
                new Post(1, "Coach de basket", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
                new Post(2, "Hockey sur glace", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
                new Post(3, "Foot en salle", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
                new Post(4, "Sparring Judo", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
                new Post(5, "Skateboard", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
            };
            // Remplir
            return View(liste);
        }
    }
}