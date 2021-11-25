﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Data
{
    public class AppDataInit
    {
        public static void seedRestaurant(ApplicationDbContext context)
        {
            if (!context.Restaurants.Any())
            {
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "McDonalds",
                        City = "Tallinn",
                        Country = "Estonia",
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "Hesburger",
                        City = "Tallinn",
                        Country = "Estonia",
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "BabyBack Ribs & BBQ",
                        City = "Tallinn",
                        Country = "Estonia",
                    });
                context.Restaurants.Add(
                    new Restaurant
                    {
                        Name = "Burger King",
                        City = "Stockholm",
                        Country = "Finland",
                    });
            }
        }
    }
}