using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Domain.Entities
{
    public class Tour
    {
        [Key]
        public int TourId { get; set; }
        public string? TourName { get; set; }
        public decimal TourPrice { get; set; }
        public int TourPopularStatus { get; set; }
        public string? TourAbout { get; set; }
        public List <Car> Cars { get; set; }   
        public List<TourImage> TourImages { get; set; }


    }
}
