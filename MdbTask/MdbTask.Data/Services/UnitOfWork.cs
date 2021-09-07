using MdbTask.Data.Context;
using MdbTask.Data.Interfaces;
using System.Threading.Tasks;

namespace MdbTask.Data.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        #region service getters
        public IMediaService MediaService
        {
            get
            {
                return new MediaService(_context);
            }
        }

        public IRatingService RatingService
        {
            get
            {
                return new RatingService(_context);
            }
        }
        #endregion

        /// <summary>
        /// Save changes to database context
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        /// <summary>
        /// Save changes to database context async
        /// </summary>
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
