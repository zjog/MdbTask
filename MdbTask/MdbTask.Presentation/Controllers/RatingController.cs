using MdbTask.Data.DTOs;
using MdbTask.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MdbTask.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly ILogger<RatingController> _logger;
        private readonly IUnitOfWork _service;

        public RatingController(ILogger<RatingController> logger, IUnitOfWork service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Save user rating for movie/show
        /// </summary>
        /// <param name="ratingData"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RatingDto ratingData)
        {
            try
            {
                await _service.RatingService.AddRating(ratingData);
                await _service.SaveAsync();

                return Ok();
            }
            catch (Exception e)
            {
                _logger.LogError($"rating POST error: {e.Message}");
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
