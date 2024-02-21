namespace TravelDeskProject.ViewModel
{
    public class UpdateStatusModel
    {
        public int RequestId { get; set; }
        public int StatusId { get; set; }
        //public int UpdatedBy { get; set; }
        //public DateTime UpdatedOn { get; set; }
        public string? StatusReason { get; set; }
    }
}
