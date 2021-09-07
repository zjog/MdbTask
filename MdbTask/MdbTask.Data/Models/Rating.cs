using System.ComponentModel.DataAnnotations;

namespace MdbTask.Data.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public int UserRating { get; set; }

        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
