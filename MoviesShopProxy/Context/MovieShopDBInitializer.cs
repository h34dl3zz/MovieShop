﻿using MoviesShopProxy.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesShopProxy.Context
{
    public class MovieShopDBInitializer : DropCreateDatabaseIfModelChanges<MovieShopContextDB>
    {
        protected override void Seed(MovieShopContextDB context)
        {
            var genre1 = new Genre() { Id = 1, Name = "Drama" };
            var genre2 = new Genre() { Id = 2, Name = "Crime" };
            var genre3 = new Genre() { Id = 3, Name = "Action" };
            var genre4 = new Genre() { Id = 4, Name = "Biography" };
            var genre5 = new Genre() { Id = 4, Name = "Music" };

            context.Genres.Add(genre1);
            context.Genres.Add(genre2);
            context.Genres.Add(genre3);
            context.Genres.Add(genre4);
            context.Genres.Add(genre5);

            context.Movies.Add(new Movie()
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Year = 1994,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/9O7gLzmreU0nGkIB6K3BsJbzvNv.jpg",
                trailerURL = "https://www.youtube.com/embed/NmzuHjWmXOc",
                Genre = genre1
            });
            context.Movies.Add(new Movie()
            {
                Id = 2,
                Title = "The Godfather",
                Year = 1972,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/d4KNaTrltq6bpkFS01pYtyXa09m.jpg",
                trailerURL = "https://www.youtube.com/embed/w0VGcWHkNeA",
                Genre = genre2
            });
            context.Movies.Add(new Movie()
            {
                Id = 3,
                Title = "The Lego Movie",
                Year = 2014,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/lMHbadNmznKs5vgBAkHxKGHulOa.jpg",
                trailerURL = "https://www.youtube.com/embed/fZ_JOBCLF-I",
                Genre = genre3
            });
            context.Movies.Add(new Movie()
            {
                Id = 4,
                Title = "The Godfather: part II",
                Year = 1974,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/tHbMIIF51rguMNSastqoQwR0sBs.jpg",
                trailerURL = "https://www.youtube.com/embed/8PyZCU2vpi8",
                Genre = genre2
            });
            context.Movies.Add(new Movie()
            {
                Id = 5,
                Title = "The Dark Knight",
                Year = 2008,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/1hRoyzDtpgMU7Dz4JF22RANzQO7.jpg",
                trailerURL = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Genre = genre3
            });
            context.Movies.Add(new Movie()
            {
                Id = 6,
                Title = "Pulp Fiction",
                Year = 1994,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/dM2w364MScsjFf8pfMbaWUcWrR.jpg",
                trailerURL = "https://www.youtube.com/embed/ewlwcEBTvcg",
                Genre = genre2
            });
            context.Movies.Add(new Movie()
            {
                Id = 7,
                Title = "Intouchables",
                Year = 2011,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/4mFsNQwbD0F237Tx7gAPotd0nbJ.jpg",
                trailerURL = "https://www.youtube.com/embed/34WIbmXkewU",
                Genre = genre4
            });
            context.Movies.Add(new Movie()
            {
                Id = 8,
                Title = "Whiplash",
                Year = 2014,
                Price = 100,
                imageURL = "https://image.tmdb.org/t/p/w396/lIv1QinFqz4dlp5U4lQ6HaiskOZ.jpg",
                trailerURL = "https://www.youtube.com/embed/7d_jQycdQGo",
                Genre = genre5
            });

            base.Seed(context);
        }
    }
}