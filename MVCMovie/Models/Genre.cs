using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMovie.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string GenreName { get; set; }

        public DateTime CreateAt { get; set; }

        public string GenreDescription { get; set; }
    }
}
