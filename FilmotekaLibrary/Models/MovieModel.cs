using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaLibrary.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public string OriginalName { get; set; }
        public string NationalName { get; set; }
        public int Year { get; set; }
        public bool IsWatched { get; set; }
        public bool IsNotRelevant { get; set; }


    }
}
