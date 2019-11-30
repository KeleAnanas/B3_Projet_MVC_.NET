using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class Post
    {
        private int? id;
        private string titre;
        private string texte;
        private string url;

        public Post() { }

        public Post(int id, string titre, string texte, string url)
        {
            this.id = id;
            this.titre = titre;
            this.texte = texte;
            this.url = url;
        }

        public int? Id
        {
            get => id;
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
            get => titre;
        }

        public string Texte
        {
            get => texte;
            set
            {
                this.texte = value;
            }
        }

        public string Url
        {
            get => url;
            set
            {
                this.url = value;
            }
        }
    }
}
