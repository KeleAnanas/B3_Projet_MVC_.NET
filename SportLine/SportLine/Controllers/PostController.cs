using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using SportLine.Models;

namespace SportLine.Controllers
{
    public class PostController : Controller
    {
        private IPostRepo postRepo;

        public PostController(IPostRepo postRepo)
        {
            this.postRepo = postRepo;
        }


        public IActionResult PostListe()
        {
           return View(postRepo.All);
        }

        public IActionResult CreerPost()
        {
            return View();
        }

        [HttpPost] //Attribut
        public IActionResult CreerPost(PostEntite post)
        {
            if (ModelState.IsValid)
            {
                post.UserId = 1;
                try
                {
                    postRepo.Save(post);
                    return RedirectToAction(nameof(PostListe));
                } // Appel du Dispose de connection (ferme la connexion)
                catch (SqlException e)
                {
                    return View();
                }
            }
            return View();
        }

        public IActionResult DetailsPost(int id)
        {
            return View(postRepo.GetById(id));
        }

    }
}