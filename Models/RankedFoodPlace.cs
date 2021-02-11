using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//this file creates the model for the restaurants, also specifies which portions are required and which aren't.

namespace CameronKeetch_Assignment4.Models
{
    //this constructor makes it so rank is read only. When the new model is called every time it is assigned a rank.
    public class RankedFoodPlace
    {
        public RankedFoodPlace(int rank)
        {
            restRank = rank;
        }
        
        [Required]
        public int restRank { get; }

        [Required]
        public string restName { get; set; }

        //this sets the favDish to the string, unless specified otherwise when created.
        public string? favDish { get; set; } = "It's all tasty!";

        [Required]
        public string restAddress { get; set; }

        [Phone]
        public string? restPhone { get; set; }

        //this sets the website to the string, unless specified otherwise when created.
        public string? restWebsite { get; set; } = "Coming soon.";


        //this portion specifically creates the array that is going to be passed so this data can be displayed on the website.
        public static RankedFoodPlace[] GetRankedFoodPlaces()
        {
            RankedFoodPlace r1 = new RankedFoodPlace(1)
            {
                restName = "Bajio",
                favDish = "Green Chicken Chile Quesadilla",
                restAddress = "4801 N University Ave #51, Provo, UT 84604",
                restPhone = "(801) 224-6668",
                restWebsite = "bajiogrillutah.com/provo-location",

            };

            RankedFoodPlace r2 = new RankedFoodPlace(2)
            {
                restName = "Five Sushi Brothers",
                restAddress = "445 Freedom Blvd 200 W, Provo, UT 84601",
                restPhone = "(385) 549-4495",
                restWebsite = "fivesushibrothers.com",

            };

            RankedFoodPlace r3 = new RankedFoodPlace(3)
            {
                restName = "Taco Amigo",
                favDish = "Smothered Bean Burrito",
                restAddress = "1395 N State St, Orem, UT 84057",
                restPhone = "(801) 224-4122",

            };

            RankedFoodPlace r4 = new RankedFoodPlace(4)
            {
                restName = "Black Sheep Cafe",
                favDish = "Hog Jowl Tacos",
                restAddress = "19 N University Ave, Provo, UT 84601",
                restPhone = "(801) 607-2485",
                restWebsite = "blacksheepcafe.com",

            };

            RankedFoodPlace r5 = new RankedFoodPlace(5)
            {
                restName = "Chom",
                restAddress = "45 300 N, Provo, UT 84601",
                restPhone = "(385) 241-7499",
                restWebsite = "chomburger.com",

            };

            return new RankedFoodPlace[] { r1, r2, r3, r4, r5 };
        }

    }
}
