using FilmotekaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilmotekaLibrary.DataAccess
{
    public class MockDataAccess : IFilmotekaDataAccess
    {
        public List<MovieModel> GetAllMoviesFromDb()
        {
            List<MovieModel> output = new();
            output.Add(new MovieModel { Id = 1, OriginalName = "Batman Begins", FileName = "Batman.Begins.2000.mkv", Year = 2000 });
            output.Add(new MovieModel { Id = 2, OriginalName = "Love Actually", FileName = "LoveActually_x264.2003.AC3.5.1.avi", Year = 2003 });
            output.Add(new MovieModel { Id = 3, OriginalName = "Rambo I, First Blood", FileName = "RamboI_1980.mp4", Year = 1980 });

            return output;
        }

        public List<FileExtensionModel> GetAllFileExtentions()
        {
            List<FileExtensionModel> output = new();
            output.Add(new FileExtensionModel { Id = 1, FileExtension = ".mkv", IsActive = true });
            output.Add(new FileExtensionModel { Id = 2, FileExtension = ".mp4", IsActive = true });
            output.Add(new FileExtensionModel { Id = 3, FileExtension = ".avi", IsActive = true });
            output.Add(new FileExtensionModel { Id = 4, FileExtension = ".mpg", IsActive = false });

            return output;
        }

        public List<FolderModel> GetAllFolders()
        {
            List<FolderModel> output = new();
            output.Add(new FolderModel { Id = 1, FolderName = @"D:\Films", IsActive = true });
            output.Add(new FolderModel { Id = 2, FolderName = @"D:\Movies", IsActive = true });
            output.Add(new FolderModel { Id = 3, FolderName = @"D:\TEST", IsActive = false });

            return output;
        }

        public List<DateWatchedModel> GetAllDateWatchedById(int id)
        {
            List<DateWatchedModel> output = new();

            switch (id)
            {
                case 1:
                    output.Add(new DateWatchedModel { Id = 7, MovieId = 1, DateWatched = new DateTime(2021, 1, 22) });
                    output.Add(new DateWatchedModel { Id = 4, MovieId = 1, DateWatched = new DateTime(2020, 1, 2) });
                    output.Add(new DateWatchedModel { Id = 1, MovieId = 1, DateWatched = new DateTime(2017, 1, 29) });
                    break;

                case 2:
                    output.Add(new DateWatchedModel { Id = 8, MovieId = 2, DateWatched = new DateTime(2021, 2, 22) });
                    output.Add(new DateWatchedModel { Id = 5, MovieId = 2, DateWatched = new DateTime(2020, 2, 2) });
                    output.Add(new DateWatchedModel { Id = 2, MovieId = 2, DateWatched = new DateTime(2017, 2, 29) });
                    break;

                case 3:
                    output.Add(new DateWatchedModel { Id = 9, MovieId = 3, DateWatched = new DateTime(2021, 3, 22) });
                    output.Add(new DateWatchedModel { Id = 6, MovieId = 3, DateWatched = new DateTime(2020, 3, 2) });
                    output.Add(new DateWatchedModel { Id = 3, MovieId = 3, DateWatched = new DateTime(2017, 3, 29) });
                    break;

                default:
                    break;
            }

            return output;
        }


    }
}
