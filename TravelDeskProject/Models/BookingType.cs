namespace TravelDeskProject.Models
{
    public class BookingType
    {
        public int BookingTypeId { get; set; }
        public string BookingTypeName { get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } 
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
