using MdbTask.Data.Context;
using MdbTask.Data.Interfaces;
using MdbTask.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MdbTask.Data.Services
{
    public class MediaService : Service<Media>, IMediaService
    {
        private DbSet<Media> _dataset;

        public MediaService(ApplicationDbContext context)
            : base(context)
        {
            _dataset = context.Media;
        }

        /// <summary>
        /// Get media as IQueryable
        /// </summary>
        /// <returns></returns>
        public IQueryable<Media> GetMedia()
        {
            return _dataset.Include(m => m.Cast).Include(m => m.Ratings);
        }
    }
}
