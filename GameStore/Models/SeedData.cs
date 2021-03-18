using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace GameStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context =
                services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Horrizon Zero Dawn", 
                        Description = "The plot follows Aloy, a young hunter in a world overrun by machines, who sets out to uncover her past.",
                        Category = "PS4", Price = 38.88M
                    },
                    new Product
                    {
                        Name = "Final Fantasy VII Remake",
                        Description = "Final Fantasy VII Remake is a 2020 action role-playing game developed and published by Square Enix.",
                        Category = "PS4", Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Halo Infinite",
                        Description = "Halo Infinite is an upcoming first-person shooter game developed by 343 Industries and published by Xbox Game Studios for Xbox.",
                        Category = "XBOX", Price = 59.50m
                    },
                    new Product
                    {
                        Name = "LEGO Star Wars: The Skywalker Saga",
                        Description = "Lego Star Wars: The Skywalker Saga is an upcoming Lego-themed action-adventure game scheduled to be released in early 2021 ",
                        Category = "XBOX", Price = 55.69m
                    },
                    new Product
                    {
                        Name = "Warcraft III: The Frozen Throne",
                        Description = "Warcraft III: The Frozen Throne is the expansion pack for Warcraft III: Reign of Chaos, a real-time strategy video game by Blizzard Entertainment.",
                        Category = "PC", Price = 15.99M
                    },
                    new Product
                    {
                        Name = "Counter-Strike",
                        Description = "Counter-Strike is a series of multiplayer first-person shooter video games in which teams of terrorists battle to perpetrate an act of terror while counter-terrorists try to prevent it.",
                        Category = "PC", Price = 16.00M
                    },
                    new Product
                    {
                        Name = "I'm a Game",
                        Description = "I'm a fun game",
                        Category = "PC", Price = 249.99m
                    },
                    new Product
                    {
                        Name = "The Boring",
                        Description = "You win if you are real bored",
                        Category = "XBOX", Price = 75m
                    },
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "PS4", Price = 1200M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}