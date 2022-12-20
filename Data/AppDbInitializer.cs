using Etickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder appBuilder)
        {
            using (var serviceScope = appBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "First Cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "First Cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "First Cinema"
                        },

                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "First Cinema"
                        }
                    });
                    context.SaveChanges();

                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "Bio fro Actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },

                         new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "Bio fro Actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },

                         new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "Bio fro Actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },

                          new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "Bio fro Actor",
                            ProfilePicURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        }

                    });
                    context.SaveChanges();

                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "Bio fro Producer",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "Bio fro Producer",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "Bio fro Producer",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },

                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "Bio fro Producer",
                            ProfilePicURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "Scoob Movie",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            CinemaId = 3,
                            ProducerId = 13,
                            MovieCategory = MovieCategory.Cartoon
                        },

                         new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "Cold Soles Movie",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            CinemaId = 1,
                            ProducerId = 14,
                            MovieCategory = MovieCategory.Drama
                        },

                          new Movie()
                        {
                            Name = "Scoob",
                            Description = "Scoob Movie",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            CinemaId = 1,
                            ProducerId = 15,
                            MovieCategory = MovieCategory.Cartoon
                        },

                           new Movie()
                        {
                            Name = "Race",
                            Description = "Race Movie",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            CinemaId = 1,
                            ProducerId = 13,
                            MovieCategory = MovieCategory.Documentary
                        },

                           new Movie()
                        {
                            Name = "Ghost",
                            Description = "Ghost Movie",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            CinemaId = 4,
                            ProducerId = 14,
                            MovieCategory = MovieCategory.Horror
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 6
                        },

                         new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 7
                        },

                        new Actor_Movie()
                        {
                            ActorId = 14,
                            MovieId = 8
                        },

                        new Actor_Movie()
                        {
                            ActorId = 15,
                            MovieId = 9
                        },

                        new Actor_Movie()
                        {
                            ActorId = 13,
                            MovieId = 10
                        },
                    });

                    context.SaveChanges();
                }
            }

        }
    }
}
