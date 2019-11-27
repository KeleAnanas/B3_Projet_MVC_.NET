using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class Post
    {
        private int id;
        private string titre;
        private string texte;
        private string photo;

        public Post(int id, string titre, string texte, string photo)
        {
            this.id = id;
            this.titre = titre;
            this.texte = texte;
            this.photo = photo;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Titre
        {
            set
            {
                titre = value;
            }
            get
            {
                return titre;
            }
        }

        public string Texte
        {
            get
            {
                return texte;
            }
            set
            {
                this.texte = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                this.photo = value;
            }
        }
    }
}
