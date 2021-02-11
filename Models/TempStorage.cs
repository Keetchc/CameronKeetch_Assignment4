using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//This is the TempStorage class that acts as a database and holds the info while the app is running.

namespace CameronKeetch_Assignment4.Models
{
    public static class TempStorage
    {
        private static List<SubmitFoodPlace> submitPlaces = new List<SubmitFoodPlace>();

        public static IEnumerable<SubmitFoodPlace> SubmitFoodPlaces => submitPlaces;

        public static void AddFoodPlace(SubmitFoodPlace submitPlace)
        {
            submitPlaces.Add(submitPlace);
        }
    }
}
