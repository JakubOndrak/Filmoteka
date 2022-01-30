using FilmotekaLibrary.Models;

namespace FilmotekaLibrary.DataAccess
{
    public interface IFilmotekaDataAccess
    {
        List<DateWatchedModel> GetAllDateWatchedById(int id);
        List<FileExtensionModel> GetAllFileExtentions();
        List<FolderModel> GetAllFolders();
        List<MovieModel> GetAllMoviesFromDb();
    }
}