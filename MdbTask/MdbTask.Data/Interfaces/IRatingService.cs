using MdbTask.Data.DTOs;
using MdbTask.Data.Models;
using System.Threading.Tasks;

namespace MdbTask.Data.Interfaces
{
    public interface IRatingService : IService<Rating>
    {
        Task AddRating(RatingDto ratingData);
    }
}
