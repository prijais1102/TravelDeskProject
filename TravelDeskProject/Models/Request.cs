using System.ComponentModel.DataAnnotations.Schema;

namespace TravelDeskProject.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public int UserId { get; set; }
        public int ProjectId {  get; set; }
        public int DepartmentId { get; set; }
        public string ReasonForTravelling { get; set; }
        public int BookingTypeId { get; set; }
        public int AadharNo { get; set; }
        [NotMapped]
        public IFormFile AadharCard { get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        public User? User { get; set; }
        public Project? Project { get; set; }
        public Department? Department { get; set; }
        public Booking? BookingType { get; set; }
        public ICollection<HotelBooking> Hotels { get; set; }
        public ICollection<AirTicketBooking> AirTickets { get; set; }
    }
}
