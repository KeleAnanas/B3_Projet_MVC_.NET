using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportLine.Models
{
    public interface IPostRepo
    {
        IEnumerable<PostEntite> All { get; }

        PostEntite GetById(int id);

        void Save(PostEntite post);


    }
}
