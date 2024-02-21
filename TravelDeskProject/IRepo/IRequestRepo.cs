
using TravelDeskProject.Models;
using TravelDeskProject.ViewModel;

namespace TravelDeskProject.IRepo
{
    public interface IRequestRepo
    {
        string AddRequest(Request Request);
        List<Request> GetRequests();
        public List<BookingType> GetBookingTypes();
        public List<FlightType> GetFlightTypes();
        public List<Location> GetAllLocations();
        public List<Location> GetDomesticLocations();
        public List<Location> GetInternationalLocations();
        public List<MealPreferenceType> GetMealPreferenceTypes();
        public List<MealType> GetMealTypes();
        public List<Project> GetProjects();
        public List<Status> GetStatus();
        public List<RequestViewModel> GetPreviousRequests(int id);
        public Request GetRequestDetailsById(int id);
        public string DeleteRequest(int id);
        public List<RequestViewModel> GetRequestDetailsByManagerId(int id);
        public List<Request> GetRequestsForHRAdmin();
        public string UpdateStatusWithReason( UpdateStatusModel data);
        public string UpdateBookingId(int id, BookingIdViewModel referenceNumber);
        public string GetStatusName(int id);
        public List<RequestViewModel> GetApprovedRequests();

    }
}
