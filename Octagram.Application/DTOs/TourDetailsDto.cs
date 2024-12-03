using Octagram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Application.DTOs
{
    public class TourDetailsDto
    {
        public int TourId { get; set; }
        public string? TourName { get; set; }
        public decimal TourPrice { get; set; }
        public string? TourAbout { get; set; }
        public List<TourImage>? TourImages { get; set; }
    }
}
