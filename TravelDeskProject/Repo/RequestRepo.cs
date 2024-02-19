
using Microsoft.AspNetCore.Mvc;
using TravelDeskProject.IRepo;
using TravelDeskProject.Models;

namespace TravelDeskProject.Repo
{
    public class RequestRepo : IRequestRepo
    {
        public TravelDbContext _db;
        public RequestRepo(TravelDbContext db)
        {
            _db = db;
        }

        public string AddRequest(Request travelRequest)
        {
            travelRequest.IsActive = true;
            _db.Requests.Add(travelRequest);
            _db.SaveChanges();
            return "Added Successfully";

        }

        public List<Request> GetRequests()
        {
            return _db.Requests.ToList();

        }
        public List<BookingType> GetBookingTypes()
        {
            return _db.Bookings.ToList();
        }
        public List<FlightType> GetFlightTypes()
        {
            return _db.FlightTypes.ToList();
        }
        public List<Location> GetAllLocations()
        {
            return _db.Locations.ToList();
        }
        public List<Location> GetDomesticLocations()
        {
            return _db.Locations.Where(x => x.Country == "India").ToList();
        }
        public List<Location> GetInternationalLocations()
        {
            return _db.Locations.Where(x => x.Country != "India").ToList();
        }
        public List<MealPreferenceType> GetMealPreferenceTypes()
        {
            return _db.MealPreferenceTypes.ToList();
        }
        public List<MealType> GetMealTypes()
        {
            return _db.MealTypes.ToList();
        }
        public List<Project> GetProjects()
        {
            return _db.Projects.ToList();
        }
        public List<Status> GetStatus()
        {
            return _db.EmployeeRequestStatus.ToList();
        }
        public List<Request> PreviousRequests(int id)
        {
            List<Request> previousRequests = _db.Requests.Where(x=>x.UserId == id && x.IsActive == true).ToList();
            return previousRequests;
        }

    }
}

