namespace TravelDeskProject.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string BookingTypeName { get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } 
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
