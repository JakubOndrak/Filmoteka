﻿using FilmotekaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilmotekaLibrary.DataAccess
{
    public static class MockDataAccess
    {
        public static List<MovieModel> GetAllMoviesFromDb()
        {
            List<MovieModel> output = new();
            output.Add(new MovieModel { Id = 1, OriginalName = "Batman Begins", FileName = "Batman.Begins.2000.mkv", Year = 2000 });
            output.Add(new MovieModel { Id = 2, OriginalName = "Love Actually", FileName = "LoveActually_x264.2003.AC3.5.1.avi", Year = 2003 });
            output.Add(new MovieModel { Id = 3, OriginalName = "Rambo I, First Blood", FileName = "RamboI_1980.mp4", Year = 1980 });
           
            return output;
        }

        public static List<FileExtensionModel> GetAllFileExtentions()
        {
            List<FileExtensionModel> output = new();
            output.Add(new FileExtensionModel { Id = 1, FileExtension = ".mkv", IsActive = true });
            output.Add(new FileExtensionModel { Id = 2, FileExtension = ".mp4", IsActive = true });
            output.Add(new FileExtensionModel { Id = 3, FileExtension = ".avi", IsActive = true });
            output.Add(new FileExtensionModel { Id = 4, FileExtension = ".mpg", IsActive = false });

            return output;
        }

        public static List<FolderModel> GetAllFolders()
        {
            List<FolderModel> output = new();
            output.Add(new FolderModel { Id = 1, FolderName = @"D:\Films", IsActive = true });
            output.Add(new FolderModel { Id = 2, FolderName = @"D:\Movies", IsActive = true });
            output.Add(new FolderModel { Id = 3, FolderName = @"D:\TEST", IsActive = false });

            return output;
        }

        public static void Test()
        {
            var file = new FileInfo(@"C:\Hry\test.txt");

        }
    }
}
