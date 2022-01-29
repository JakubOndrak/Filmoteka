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
        public string FileName { get; set; }
        public string FolderName { get; set; }
        public int Year { get; set; }
        public DateTime LastWatched { get; set; }
        public bool IsNotRelevant { get; set; }


    }
}
