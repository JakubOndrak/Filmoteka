using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaLibrary.Models
{
    public class FolderModel
    {
        public int Id { get; set; }
        public string FolderName { get; set; }
        public bool IsActive { get; set; }

        //TODO - add property: bool that flags if read subfolders too
    }
}
