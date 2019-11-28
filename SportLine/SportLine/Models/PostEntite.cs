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
        public int Id { get; set; }

        [Required]
        public string Titre { get; set; }
        [Required]
        public string Texte { get; set; }
        public string Url { get; set; }
        #endregion
    }
}
