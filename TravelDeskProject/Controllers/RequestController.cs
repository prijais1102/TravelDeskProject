using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using TravelDeskProject.IRepo;
using TravelDeskProject.Models;

namespace TravelDeskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : Controller
    {
        public IRequestRepo _requestRepo;
        public RequestController(IRequestRepo requestRepo)
        {
            _requestRepo = requestRepo;
        }
        [HttpPost]
        [Route("AddRequest")]
        public IActionResult AddRequest(Request request)
        {
            if (Request != null)
            {
                request.CreatedBy = request.UserId;
                request.StatusId = 1;
                request.IsActive = true;
                request.CreatedOn= DateTime.Now;
                _requestRepo.AddRequest(request);
                return Ok("Added successfully !");
            }
            else
            {
                return BadRequest();
            }

        }
        [HttpPost("Upload")]
        public void UploadFiles(IFormFile passportFile, IFormFile visaFile, string employeeName, string employeeID)
        {
            //List<string> data = new List<string>();
            var folderName = $"{employeeName}_{employeeID}";
            var filePath1 =
                //change path 
                Path.Combine(@"C:\Users\PriyaJaiswal\Desktop\Assessment\CSharp\TravelDeskProject\Documents",
                folderName);
            if (!Directory.Exists(filePath1))
            {
                Directory.CreateDirectory(filePath1);
            }
            if (passportFile != null && passportFile.Length > 0)
            {

                var todayDate = DateTime.Now.ToString("yyyyMMdd");
                var passportFileName = $"{employeeName}_passport_{todayDate}{Path.GetExtension(passportFile.FileName)}";
                var passportFilePath = Path.Combine(filePath1, passportFileName);

                using (var stream = new FileStream(passportFilePath, FileMode.Create))
                {
                    passportFile.CopyTo(stream);
                    //data.Add("Passport");
                }
            }

            if (visaFile != null && visaFile.Length > 0)
            {
                var todayDate = DateTime.Now.ToString("yyyyMMdd");
                var visaFileName = $"{employeeName}_visa{todayDate}{Path.GetExtension(visaFile.FileName)}";
                var visaFilePath = Path.Combine(filePath1, visaFileName);
                using (var stream = new FileStream(visaFilePath, FileMode.Create))
                {
                    visaFile.CopyTo(stream);
                    //data.Add("Visa");
                }
            }
            //return data;
        }

        [HttpGet]
        [Route("GetRequests")]
        public IActionResult GetRequests()
        {

            List<Request> requests = _requestRepo.GetRequests();
            return Ok(requests);
        }
        [HttpGet]
        [Route("GetBookingTypes")]
        public IActionResult GetBookingTypes()
        {
            List<BookingType> bookingTypes = _requestRepo.GetBookingTypes();
            return Ok(bookingTypes);

        }
        [HttpGet]
        [Route("GetFlightTypes")]
        public IActionResult GetFlightTypes()
        {
            List<FlightType> flightTypes = _requestRepo.GetFlightTypes();
            return Ok(flightTypes);
        }
        [HttpGet]
        [Route("GetAllLocations")]
        public IActionResult GetAllLocations()
        {
            List<Location> getAllLocations = _requestRepo.GetAllLocations();
            return Ok(getAllLocations);

        }
        [HttpGet]
        [Route("GetDomesticLocations")]
        public IActionResult GetDomesticLocations()
        {
            List<Location> getDomesticLocations = _requestRepo.GetDomesticLocations();
            return Ok(getDomesticLocations);

        }
        [HttpGet]
        [Route("GetInternationalLocations")]
        public IActionResult GetInternationalLocations()
        {
            List<Location> getInternationalLocations = _requestRepo.GetInternationalLocations();
            return Ok(getInternationalLocations);

        }
        [HttpGet]
        [Route("GetMealPreferenceTypes")]
        public IActionResult GetMealPreferenceTypes()
        {
            List<MealPreferenceType> getMealPreferenceTypes= _requestRepo.GetMealPreferenceTypes();
            return Ok(getMealPreferenceTypes);
        }
        [HttpGet]
        [Route("GetMealTypes")]
        public IActionResult GetMealTypes()
        {
            List<MealType> getMealTypes = _requestRepo.GetMealTypes();
            return Ok(getMealTypes);
        }
        [HttpGet]
        [Route("GetProjects")]
        public IActionResult GetProjects()
        {
            List<Project> projects = _requestRepo.GetProjects();
            return Ok(projects);
        }
        [HttpGet]
        [Route("GetStatus")]
        public IActionResult GetStatus()
        {
            List<Status> statuses = _requestRepo.GetStatus();
            return Ok(statuses);
        }
        [HttpGet]
        [Route("PreviousRequests")]
        public IActionResult PreviousRequests(int id)
        {
            List<Request> previousRequests = _requestRepo.PreviousRequests(id);
            return Ok(previousRequests);
        }
    }
}