using System.ComponentModel.DataAnnotations;

namespace Flight.Models
{
    public class FlightModel
    {
        public int FlightModelId { get; set; }

        [Required(ErrorMessage = "Please enter the FlightNumber.")]
        public string FlightNumber { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter the From.")]
        public string From { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter the To.")]
        public string To { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Please enter the Date.")]
        public string Date { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the price.")]
        public int? Price { get; set; }
    }
}
