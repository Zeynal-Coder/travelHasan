using Microsoft.EntityFrameworkCore;
using Octagram.Application.DTOs;
using Octagram.Domain.Entities;
using Octagram.Domain.Repositories;
using Octagram.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Infrastructure.Repositories
{
    public class TourRepository(ApplicationDbContext context) : GenericRepository<Tour>(context), ITourRepository
    {
        public async Task<IEnumerable<Tour>> GetAllToursAsync()
        {
            return await Context.Tours
                .Include(t => t.Cars)
                .Include(t => t.TourImages) 
               // .Include(t=> t)// Burada bütün şəkilləri daxil edirik, amma yalnız birini seçəcəyik
                .Select(x => new Tour
                {
                    TourId = x.TourId,
                    TourName = x.TourName,
                    TourPopularStatus = x.TourPopularStatus

                })
                .ToListAsync();
        }



        public async Task<Tour> GetByIdAsync(int tourId)
        {
            Tour? tour = await Context.Tours
                .Where(t => t.TourId == tourId)  // Verilən TourId-ə əsasən filtr
                .Include(t => t.TourImages) 
                // TourImages cədvəlini daxil edirik
                .Select(t => new Tour           // Yalnız lazım olan sahələri seçirik
                {
                    TourId = t.TourId,
                    TourName = t.TourName,
                    TourAbout = t.TourAbout,  // TourDetail sahəsini əlavə edirik
                    TourImages = t.TourImages    // Şəkilləri daxil edirik
                })
                .FirstOrDefaultAsync();         // Birinci uyğun olanı əldə edirik




            return tour!;
        }

    }
}

