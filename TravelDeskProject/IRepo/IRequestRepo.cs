
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
        public List<Request> GetPreviousRequests(int id);
        public Request GetRequestDetailsById(int id);
        public string DeleteRequest(int id);
        public List<Request> GetRequestDetailsByManagerId(int id);
        public List<Request> GetRequestsForHRAdmin();
        public string UpdateStatusWithReason(int id, UpdateStatusModel data);
        public string UpdateBookingId(int id, int referenceNumber);
    }
}
