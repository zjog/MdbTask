using System.Threading.Tasks;

namespace MdbTask.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IMediaService MediaService { get; }

        IRatingService RatingService { get; }

        void Save();

        Task SaveAsync();
    }
}
