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

        public IActionResult PostListe()
        {

            var chaineConnexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\theod\Desktop\EPSI B3\.net\B3_Projet_MVC_.NET\SportLine\SportLine\Data\data.mdf;Integrated Security=True;Connect Timeout=30";
            using (var connection = new SqlConnection(chaineConnexion))
            {
                var galerie = connection.Query<PostEntite>("SELECT * FROM Post");
                // Remplir
                return View(this.liste);
            }
        }

        public IActionResult Creer()
        {
            return View();
        }

        [HttpPost] //Attribut
        public IActionResult Creer(PostEntite nouveau)
        {
            return View();
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