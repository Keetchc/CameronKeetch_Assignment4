using CameronKeetch_Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CameronKeetch_Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }



        //shows the index page with the 5 recommended restaurants in string format.
        public IActionResult Index()
        {
            List<string> restList = new List<string>();

            foreach (RankedFoodPlace r in RankedFoodPlace.GetRankedFoodPlaces())
            {
                restList.Add($"#{r.restRank}: {r.restName} \\ Favorite Dish: {r.favDish} \\ Location: {r.restAddress} \\ Phone: {r.restPhone} \\ Website: {r.restWebsite}");
            }

            return View(restList);
        }

        //displays when the submitfoodplace page is requested.
        [HttpGet]
        public IActionResult SubmitFoodPlace()
        {
            return View();
        }

        //is called when the form is posted, validates the Model and passes to the confirmation page if all is correct. If not it stays on the same view and displays errors.
        [HttpPost]
        public IActionResult SubmitFoodPlace(SubmitFoodPlace submitFoodResponse)
        {
            if (ModelState.IsValid)
            {
                TempStorage.AddFoodPlace(submitFoodResponse);

                return View("Confirmation", submitFoodResponse);
            }

            else
            {
                return View();
            }
        }

        //shows the RecommendedPlacesList, passing the TempStorage so it can be displayed.
        public IActionResult RecommendedPlacesList()
        {
            return View(TempStorage.SubmitFoodPlaces);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
