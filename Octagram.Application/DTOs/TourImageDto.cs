using Octagram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Application.DTOs
{
    public class TourImageDto
    {
        public int TourImagesId { get; set; }
        public string? TourImgageName { get; set; }
        public Tour? Tour { get; set; }
        public int TourId { get; set; }
        public int IsMainImage { get; set; }
    }
}
