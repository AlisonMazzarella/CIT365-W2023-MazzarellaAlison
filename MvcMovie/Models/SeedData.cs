using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Rating = "PG",
                    Price = 7.50M
                },
                new Movie
                {
                    Title = "The Saratov Approach",
                    ReleaseDate = DateTime.Parse("2013-10-15"),
                    Genre = "Thriller",
                    Rating = "PG-13",
                    Price = 8.50M
                },
                new Movie
                {
                    Title = "Johnny Lingo",
                    ReleaseDate = DateTime.Parse("1969-2-23"),
                    Genre = "Romantic Comedy",
                    Rating = "G",
                    Price = 9.50M
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-03"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 6.50M
                }
            );
            context.SaveChanges();
        }
    }
}