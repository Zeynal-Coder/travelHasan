using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Octagram.Domain.Entities
{
    public class Wishlist
    {
        [Key]
        public int WishlistId { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }
    }
}
