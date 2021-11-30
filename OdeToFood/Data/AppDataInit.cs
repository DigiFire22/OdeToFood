using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Data
{
    public class AppDataInit
    {
        
        public static void SeedRestaurant(ApplicationDbContext context)
        {
            if (!context.Restaurants.Any())
            {
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "McDonalds",
                        City = "Tallinn",
                        Country = "Estonia",
                        Review = new List<RestarauntReview>()
                        {
                            new RestarauntReview()
                            {
                                Rating = 10,
                                Body = "It's Shit"
                            }
                        }
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "Hesburger",
                        City = "Tallinn",
                        Country = "Estonia",
                        Review = new List<RestarauntReview>()
                        {
                            new RestarauntReview()
                            {
                                Rating = 10,
                                Body = "It's Not Bad"
                            }
                        }
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "BabyBack Ribs & BBQ",
                        City = "Tallinn",
                        Country = "Estonia",
                        Review = new List<RestarauntReview>()
                        {
                            new RestarauntReview()
                            {
                                Rating = 10,
                                Body = "It's Perfection"
                            }
                        }
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "Burger King",
                        City = "Stockholm",
                        Country = "Finland",
                        Review = new List<RestarauntReview>()
                        {
                            new RestarauntReview()
                            {
                                Rating = 10,
                                Body = "It's Okay"
                            }
                        }
                    });
                context.SaveChanges();
            }
        }
    }
}
