using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Domain.Entities
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string CarName { get; set; }
        public decimal CarPrice { get; set; }
        public string CarPersonCount { get; set; }
        public int? TourId { get; set; }
        public Tour Tour { get; set; }

    }
}
