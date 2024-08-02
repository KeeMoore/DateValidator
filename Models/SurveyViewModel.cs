using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyVal.Models
{
    public class SurveyViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name should be no less than two characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Favorite Language is required.")]
        public string? FavoriteLanguage { get; set; }

        [MinLength(20, ErrorMessage = "Comment should be more than 20 characters.")]
        public string? Comment { get; set; }

        [FutureDate(ErrorMessage = "The date cannot occur after today.")]
        public DateTime SurveyDate { get; set; }
    }
}
