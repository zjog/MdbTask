using AutoMapper;
using MdbTask.Data.Interfaces;
using MdbTask.Data.Models;
using MdbTask.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using static MdbTask.Data.Enums;

namespace MdbTask.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MediaController : ControllerBase
    {
        private readonly ILogger<MediaController> _logger;
        private readonly IUnitOfWork _service;
        private readonly IMapper _mapper;

        public MediaController(ILogger<MediaController> logger, IUnitOfWork service, IMapper mapper)
        {
            _logger = logger;
            _service = service;
            _mapper = mapper;
        }

        /// <summary>
        /// Get media by MediaType, filter if required
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="type"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string searchTerm, int type, int limit )
        {
            try
            {
                var media = _service.MediaService.GetMedia().Where(m => m.Type == (MediaType)type);

                if (media == null)
                {
                    return NoContent();
                }

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    //TODO: implement search query parser

                    searchTerm = searchTerm.Trim().ToLower();

                    media = media.Where(m => m.Title.ToLower().Contains(searchTerm)
                    || m.Descritpion.ToLower().Contains(searchTerm)
                    || m.Cast.Any(c => c.Name.ToLower().Contains(searchTerm)));
                }

                var filteredMedia = await media.ToListAsync();

                var resultVms = new List<MediaVm>();

                for (int i = 0; i < filteredMedia.Count(); i++)
                {
                    resultVms.Add(_mapper.Map<MediaVm>(filteredMedia[i]));
                    resultVms[i].AverageRating = filteredMedia[i].Ratings.Count > 0
                        ? CalculateAvgRating(filteredMedia[i].Ratings)
                        : 0;
                    resultVms[i].ReleaseYear = filteredMedia[i].ReleaseDate.Year.ToString();
                }

                return Ok(resultVms.OrderByDescending(m => m.AverageRating).Skip(limit - 10).Take(limit));
            }
            catch (Exception e)
            {
                _logger.LogError($"media/filter GET error: {e.Message}");
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        /// <summary>
        /// Calculate average rating
        /// </summary>
        /// <param name="ratings"></param>
        /// <returns></returns>
        private static double CalculateAvgRating(List<Rating> ratings)
        {
            double result = (double)ratings.Sum(r => r.UserRating) / ratings.Count;

            return Math.Round(result, 2);
        }
    }
}
