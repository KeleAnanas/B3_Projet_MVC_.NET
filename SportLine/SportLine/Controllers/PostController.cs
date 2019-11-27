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
        private List<Post> liste = new List<Post>()
        {
            new Post(1, "Coach de basket", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
            new Post(2, "Hockey sur glace", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
            new Post(3, "Foot en salle", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
            new Post(4, "Sparring Judo", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
            new Post(5, "Skateboard", "Nous avons besoin d'un coach de basket", "https://basket-image.jpg"),
        };

        public IActionResult PostListe()
        {
            // Remplir
            return View(this.liste);
        }

        public IActionResult DetailsPost(int id)
        {
            Post details = this.Liste.Find(x => x.Id == id);
            return View(details);
        }

        public List<Post> Liste
        {
            get => this.liste;
        }

    }
}