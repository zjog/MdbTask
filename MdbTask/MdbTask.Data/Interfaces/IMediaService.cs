using MdbTask.Data.Models;
using System.Linq;

namespace MdbTask.Data.Interfaces
{
    public interface IMediaService : IService<Media>
    {
        IQueryable<Media> GetMedia();
    }
}
