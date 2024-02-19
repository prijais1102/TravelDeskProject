
using TravelDeskProject.Models;

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
        public List<Request> PreviousRequests(int id);
    }
}
