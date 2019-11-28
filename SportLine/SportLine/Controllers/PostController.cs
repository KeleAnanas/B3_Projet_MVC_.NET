using System;
using System.Collections.Generic;
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
        private List<Post> liste = new List<Post>();
        string chaineConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\theod\Desktop\EPSI B3\.net\B3_Projet_MVC_.NET\SportLine\SportLine\Data\data.mdf;Integrated Security=True;Connect Timeout=30";
       
        public IActionResult PostListe()
        {
            using (var connection = new SqlConnection(this.chaineConnexion))
            {
                var galerie = connection.Query<PostEntite>("SELECT * FROM Post");
                // Remplir
                return View(this.liste);
            }
        }

        public IActionResult CreerPost()
        {
            return View();
        }

        [HttpPost] //Attribut
        public IActionResult CreerPost(PostEntite nouveau)
        {
            using (var connection = new SqlConnection(this.chaineConnexion))
            {
                connection.Execute()
            }
            return RedirectToRoute(nameof(PostListe));
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