
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
        public List<RequestViewModel> GetPreviousRequests(int id)
        {
            var query =
           (from request in _db.Requests
            join status in _db.EmployeeRequestStatus on request.StatusId equals status.StatusId
            join bookingType in _db.Bookings on request.BookingTypeId equals bookingType.BookingTypeId
            where request.IsActive == true
            select new RequestViewModel
            {
                RequestId = request.RequestId,
                ReasonForTravelling = request.ReasonForTravelling,
                BookingTypeName = bookingType.BookingTypeName,
                StatusName = status.StatusName,
                StatusReason=request.StatusReason,
            }).ToList();
            return query;
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
        public List<RequestViewModel> GetRequestDetailsByManagerId(int id)
        {
            var query =
          (from request in _db.Requests
           join status in _db.EmployeeRequestStatus on request.StatusId equals status.StatusId
           join bookingType in _db.Bookings on request.BookingTypeId equals bookingType.BookingTypeId
           where request.IsActive == true && request.ManagerId==id

           select new RequestViewModel
           {
               RequestId = request.RequestId,
               ReasonForTravelling = request.ReasonForTravelling,
               BookingTypeName = bookingType.BookingTypeName,
               StatusName = status.StatusName,
               StatusReason = request.StatusReason,
           }).ToList();
            return query;
        }
        public List<Request> GetRequestsForHRAdmin()
        {
            List<Request> list=_db.Requests.Where(x=>x.StatusId == 3).ToList();
            return list;
        }
        public string UpdateStatusWithReason(UpdateStatusModel data)
        {
            var temp=_db.Requests.Where(x=>x.RequestId==data.RequestId).FirstOrDefault();
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
        public List<RequestViewModel> GetApprovedRequests()
        {
            var query =
          (from request in _db.Requests
           join status in _db.EmployeeRequestStatus on request.StatusId equals status.StatusId
           join bookingType in _db.Bookings on request.BookingTypeId equals bookingType.BookingTypeId
           where request.IsActive == true && request.StatusId == 3

           select new RequestViewModel
           {
               RequestId = request.RequestId,
               ReasonForTravelling = request.ReasonForTravelling,
               BookingTypeName = bookingType.BookingTypeName,
               StatusName = status.StatusName,
               StatusReason = request.StatusReason,
           }).ToList();
            return query;
        }
        public string UpdateBookingId(int id, BookingIdViewModel referenceNumber)
        {
            var temp=_db.Requests.Where(x=>x.RequestId == id).FirstOrDefault();
            if(temp !=null)
            {
                temp.BookingId = referenceNumber.BookingId;
                _db.Requests.Update(temp);
                _db.SaveChanges();
                return "Booking Id has been generated.";
            }
            return "No request found.";           
        }
        public string GetStatusName(int id)
        {
            var temp=_db.Requests.Where(x=>x.UserId == id && x.IsActive==true).FirstOrDefault();
            if (temp!=null)
            {
                int statusId = temp.StatusId;
                var temp1=_db.EmployeeRequestStatus.Where(x=>x.StatusId==statusId).FirstOrDefault();
                if(temp1!=null)
                {
                    return temp1.StatusName;
                }
            }
            return "Request Not Found";
        }
    }
}

