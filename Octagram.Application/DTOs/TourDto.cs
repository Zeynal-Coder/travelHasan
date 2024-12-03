using Octagram.Domain.Entities;

namespace Octagram.Application.DTOs
{
    public class TourDto
    {
        public int TourId { get; set; }
        public string? TourName { get; set; }
        public decimal TourPrice { get; set; }
        public int TourPopularStatus { get; set; }
        public string? TourAbout { get; set; }
        public List<Car>? Cars { get; set; }
        public List<TourImage>? TourImages { get; set; }

        public List<ListItem>? Images { get; set; }

        public class ListItem
        {
            public int Id { get; set; }
            public string? ImageUrL { get; set; }
        }
    }
}
