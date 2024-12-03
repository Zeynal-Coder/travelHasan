using Octagram.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Application.Interfaces
{
    public interface ITourService
    {
        Task<IEnumerable<TourDto>> GetAllToursAsync();
        Task<IEnumerable<TourDto>> GetTourByIdAsync(int tourId);

    }
}
