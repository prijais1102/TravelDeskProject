using System.ComponentModel.DataAnnotations;

namespace TravelDeskProject.Models
{
    public class MealPreferenceType
    {
        [Key]
        public int MealPreferenceTypeId { get; set; }
        public string MealPreferenceName { get; set; }
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
