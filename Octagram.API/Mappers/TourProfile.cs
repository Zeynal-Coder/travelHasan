using AutoMapper;
using Octagram.Application.DTOs;
using Octagram.Domain.Entities;

namespace Octagram.API.Mappers
{
    public class TourProfile : Profile
    {
        public TourProfile()
        {
            CreateMap<Tour, TourDto>().ReverseMap();
            CreateMap<Tour, TourDetailsDto>().ReverseMap();
        }
    }
}
