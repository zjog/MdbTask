using MdbTask.Data.Models;

namespace MdbTask.Data.ViewModels
{
    public class MediaVm : Media
    {
        public double AverageRating { get; set; }

        public string ReleaseYear { get; set; }
    }
}
