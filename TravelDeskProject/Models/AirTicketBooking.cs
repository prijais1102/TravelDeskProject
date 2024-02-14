using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelDeskProject.Models
{
    public class AirTicketBooking
    {
        [Key]
        public int AirTicketBookingId { get; set; } 
        public int FlightTypeId { get; set; }
        public int? PassportNo { get; set; }

        [NotMapped]
        public IFormFile? Passport { get; set; }
        [NotMapped]
        public IFormFile? Visa { get; set; }
        public DateTime? Date{ get; set; }
        public int LocationId {  get; set; }

        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public FlightType? FlightType { get; set; }
        public Location? Location { get; set; }
    }
}
