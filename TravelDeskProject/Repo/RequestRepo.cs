
using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TravelDeskProject.IRepo;
using TravelDeskProject.Models;
using TravelDeskProject.ViewModel;

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
        public List<Request> GetPreviousRequests(int id)
        {
            List<Request> previousRequests = _db.Requests.Where(x=>x.UserId == id && x.IsActive == true).ToList();
            return previousRequests;
        }
        public Request GetRequestDetailsById(int id)
        {
            Request requestDetails =_db.Requests.Where(x=>x.RequestId == id && x.IsActive == true).FirstOrDefault();
            return requestDetails;
        }
        public string DeleteRequest(int id)
        {
            Request request = _db.Requests.Where(x => x.RequestId == id && x.IsActive == true).FirstOrDefault();
            if(request == null)
            {
                return "No request found";
            }
            request.IsActive = false;
            _db.SaveChanges();
            return "Request deleted successfully";
        }
        public List<Request> GetRequestDetailsByManagerId(int id)
        {
            List<Request> list=_db.Requests.Where(x=>x.ManagerId == id).ToList();
            return list;
        }
        public List<Request> GetRequestsForHRAdmin()
        {
            List<Request> list=_db.Requests.Where(x=>x.StatusId == 3).ToList();
            return list;
        }
        public string UpdateStatusWithReason(int id,UpdateStatusModel data)
        {
            var temp=_db.Requests.Where(x=>x.RequestId==id).FirstOrDefault();
            if(temp !=null)
            {
                temp.StatusId = data.StatusId;
                temp.StatusReason = data.StatusReason;
                temp.UpdatedOn = DateTime.Now;
                temp.UpdatedBy = temp.ManagerId;
                _db.Requests.Update(temp);
                _db.SaveChanges();
                return "Updated Successfully !";
            }
            return "No request found.";
        }
        public string UpdateBookingId(int id, int referenceNumber)
        {
            var temp=_db.Requests.Where(x=>x.RequestId == id).FirstOrDefault();
            if(temp !=null)
            {
                temp.BookingId = referenceNumber;
                _db.Requests.Update(temp);
                _db.SaveChanges();
                return "Booking Id has been generated.";
            }
            return "No request found.";           
        }
    }
}

