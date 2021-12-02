﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Data;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _Context;
       public ReviewsController(ApplicationDbContext context)
        {
            _Context = context;
        }
        // GET: ReviewsController
        public ActionResult Index([Bind(Prefix = "Id")] int restaurantId)
        {
            var model = _Context.Restaurants.Find(restaurantId);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create(int restaurantId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RestarauntReview review)
        {
            if (ModelState.IsValid)
            {
                _Context.Reviews.Add(review);
                _Context.SaveChanges();
                return RedirectToAction(nameof(Index), new { Id = review.RestaurantId });
            }
            return View(review);
        }
    }
}
