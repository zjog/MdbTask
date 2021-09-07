using MdbTask.Data.Context;
using MdbTask.Data.DTOs;
using MdbTask.Data.Interfaces;
using MdbTask.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MdbTask.Data.Services
{
    public class RatingService : Service<Rating>, IRatingService
    {
        private DbSet<Rating> _dataset;

        public RatingService(ApplicationDbContext context)
            : base(context)
        {
            _dataset = context.Ratings;
        }

        /// <summary>
        /// Add user rating
        /// </summary>
        /// <param name="ratingData"></param>
        /// <returns></returns>
        public async Task AddRating(RatingDto ratingData)
        {
            var rating = new Rating
            {
                MediaId = ratingData.MediaId,
                UserRating = ratingData.UserRating
            };

            await _dataset.AddAsync(rating);
        }
    }
}
