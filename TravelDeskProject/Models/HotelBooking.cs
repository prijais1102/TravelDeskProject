using System.ComponentModel.DataAnnotations.Schema;

namespace TravelDeskProject.Models
{
    public class HotelBooking
    {
        public int HotelBookingId { get; set; }         
        public int RequestId { get; set; }
       
        public int LocationId { get; set; }
        public int MealTypeId { get; set; }
        public int MealPreferenceId { get; set; }
        

        public int NoOfDays { get; set; }
        public DateTime Date {  get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("RequestId")]
        public Request? Request { get; set; }
        [ForeignKey("LocationId")]
        public Location? Location { get; set; }
        [ForeignKey("MealTypeId")]
        public MealType? MealType { get; set; }
        [ForeignKey("MealPreferenceId")]
        public MealPreferenceType? MealPreference { get; set; }

    }
}
