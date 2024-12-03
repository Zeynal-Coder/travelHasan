using AutoMapper;
using Octagram.Application.DTOs;
using Octagram.Application.Exceptions;
using Octagram.Application.Interfaces;
using Octagram.Domain.Entities;
using Octagram.Domain.Repositories;

namespace Octagram.Application.Services
{

    public class TourService(
    ITourRepository tourRepository, IMapper mapper)
    : ITourService
    {
        public async Task<IEnumerable<TourDto>> GetAllToursAsync()
        {
            var stories = await tourRepository.GetAllToursAsync();

            return mapper.Map<IEnumerable<TourDto>>(stories);

        }

        public async Task<IEnumerable<TourDto>> GetTourByIdAsync(int tourId)
        {
            var tour = await tourRepository.GetByIdAsync(tourId);
            if (tour == null)
            {
                throw new NotFoundException("Tour not found.");
            }

            return mapper.Map<IEnumerable<TourDto>>(tour);
        }

    }
}
