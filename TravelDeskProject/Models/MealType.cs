namespace TravelDeskProject.Models
{
    public class MealType
    {
        public int MealTypeId { get; set; }
        public string MealTypeName { get; set;}
        public int CreateBy { get; set; }
        public int? UpdateBy { get; set; } = null;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}
