using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class PostEntite
    {
        #region Propriétés automatiques
        public int? Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La longueur du titre est au moins de 2 charactères")]
        public string Titre { get; set; }
        [Required]
        public string Texte { get; set; }
        public string Url { get; set; }
        public int UserId { get; set; }
        #endregion
    }
}
