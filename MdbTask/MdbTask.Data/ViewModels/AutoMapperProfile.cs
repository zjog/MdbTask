using AutoMapper;
using MdbTask.Data.Models;

namespace MdbTask.Data.ViewModels
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Media, MediaVm>();
        }
    }
}
