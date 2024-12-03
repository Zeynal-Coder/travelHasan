using Microsoft.AspNetCore.Mvc;
using Octagram.API.Attributes;
using Octagram.Application.DTOs;
using Octagram.Application.Interfaces;
using Octagram.Application.Services;

namespace Octagram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController(ITourService tourService) : ControllerBase
    {
        [HttpGet("tours")]
        [AuthorizeMiddleware("User")]
        public async Task<ActionResult<IEnumerable<TourDto>>> GetAllTours()
        {
            var tours = await tourService.GetAllToursAsync();
            if (tours != null)
            {
                return Ok(tours);
            }

            return NotFound();
        }

        [HttpGet("{tourId:int}")]
        [AuthorizeMiddleware("User")]
        public async Task<ActionResult<TourDetailsDto>> GetPostById(int tourId)
        {
            var tour = await tourService.GetTourByIdAsync(tourId);
            if (tour != null)
            {
                return Ok(tour);
            }

            return NotFound();
        }

    }
}
