using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//this model allows for the user to add a restaurant to a list with a favorite dish, and display it on a different page.

namespace CameronKeetch_Assignment4.Models
{

    //each attribute has requirements and an error message that will display. The Phone number requires it to be in a certain format.
    public class SubmitFoodPlace
    {
        [Required(ErrorMessage = "You must enter your name.")]
        public string userName { get; set; }

        [Required(ErrorMessage = "You must enter the restaurant name.")]
        public string restName { get; set; }

        [Required(ErrorMessage = "You must enter a favorite dish.")]
        public string favDish { get; set; } = "It's all tasty!";

        [Required(ErrorMessage ="You must enter a valid phone number ###-###-####.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[1-9]\d{2}-\d{3}-\d{4}")]
        public string restPhone { get; set; }
    }
}
