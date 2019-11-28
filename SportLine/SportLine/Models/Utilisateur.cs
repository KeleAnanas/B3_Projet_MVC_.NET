using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class Utilisateur
    {
        private string id;
        private string nom;

        public Utilisateur(string nom)
        {
            this.nom = nom;
        }
    }
}
