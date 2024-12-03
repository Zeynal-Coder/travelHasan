using Octagram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Domain.Repositories
{
    public interface ITourRepository
    {
        Task<IEnumerable<Tour>> GetAllToursAsync();

        Task<Tour> GetByIdAsync(int tourId);
    }
}
