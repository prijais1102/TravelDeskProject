using Microsoft.AspNetCore.Mvc;
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
        public IActionResult AddRequest(Request Request)
        {
            if (Request != null)
            {
                _requestRepo.AddRequest(Request);
                return Ok("Added successfully !");
            }
            else
            {
                return BadRequest();
            }

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
            List<Booking> bookingTypes = _requestRepo.GetBookingTypes();
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
    }
}