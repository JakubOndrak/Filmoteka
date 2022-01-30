using FilmotekaLibrary.DataAccess;
using FilmotekaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmotekaLibrary.Processors
{
    public class MovieProcessor
    {
        private readonly IFilmotekaDataAccess filmotekaDataAccess = new MockDataAccess();
        private readonly List<MovieModel> moviesInDb = new ();
        private readonly List<FolderModel> movieFolders = new ();
        private readonly List<FileExtensionModel> fileExtensions = new();

        public MovieProcessor()
        {
            moviesInDb = filmotekaDataAccess.GetAllMoviesFromDb();
            movieFolders = filmotekaDataAccess.GetAllFolders();
            fileExtensions = filmotekaDataAccess.GetAllFileExtentions();
        }

        
    }
}
