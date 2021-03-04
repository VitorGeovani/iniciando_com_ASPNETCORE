using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcFilmes.Data;
using System;
using System.Linq;

namespace MvcFilmes.Models
{
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
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Comédia Romântica",
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comédia",
                        Rating = "R",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comédia",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Ocidental",
                        Rating = "R",
                        Price = 3.99M
                    },
                    new Movie
                    {
                        Title = "Velozes e Furiosos 9",
                        ReleaseDate = DateTime.Parse("2099-1-01"),
                        Genre = "Ocidental",
                        Rating = "R",
                        Price = 99.99M
                    },
                    new Movie
                    {
                        Title = "Velozes e Furiosos 100",
                        ReleaseDate = DateTime.Parse("3099-1-01"),
                        Genre = "Ocidental",
                        Rating = "R",
                        Price = 99.98M
                    }
                );
                context.SaveChanges();
            }
        }
}   }