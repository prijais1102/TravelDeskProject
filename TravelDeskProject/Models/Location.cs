namespace TravelDeskProject.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string City {  get; set; }
        public string Country { get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
