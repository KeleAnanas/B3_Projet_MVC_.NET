using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public class PostRepo : IPostRepo
    {
        private IDbConnection connection;

        public PostRepo(IDbConnection connection)
        {
            this.connection = connection;
        }

        public IEnumerable<PostEntite> All => connection.Query<PostEntite>("SELECT * FROM Post");

        public PostEntite GetById(int id) =>
            connection.QueryFirst<PostEntite>("SELECT * FROM Post WHERE Id = @Id", new { Id = id });// Objet anonyme

        public void Save(PostEntite Post)
        {
            connection.Execute(
                Post.Id.HasValue
                     ? "UPDATE INTO Post (Titre, Url, UserId) VALUES (@Titre, @Url, @UserId)"
                     : "INSERT INTO Post (Titre, Url, UserId) VALUES (@Titre, @Url, @UserId)",
                        Post
            );
        }
    }
}
