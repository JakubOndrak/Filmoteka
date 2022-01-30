using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaLibrary.Models
{
    public class DateWatchedModel
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime DateWatched { get; set; }
    }
}
