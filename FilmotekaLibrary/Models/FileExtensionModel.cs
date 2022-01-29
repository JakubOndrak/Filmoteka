using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaLibrary.Models
{
    public class FileExtensionModel
    {
        public int Id { get; set; }
        public string FileExtension { get; set; }
        public bool IsActive { get; set; }
    }
}
