using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class Utilisateur
    {
        private string id;
        private string nom;

        public Utilisateur() { }

        public Utilisateur(string nom)
        {
            this.nom = nom;
        }

        public string Id
        {
            get => id;
        }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le nom doit faire 3 charactères minimum")]
        public string Nom
        {
            get => this.nom;
            set
            {
                this.nom = value;
            }
        }
    }
}
