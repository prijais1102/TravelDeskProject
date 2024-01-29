using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelDeskProject.IRepo;
using TravelDeskProject.Models;
using TravelDeskProject.Repo;

namespace TravelDeskProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        IUserRepo _userRepo;
        public TravelController(IUserRepo userRepo)
        {
            _userRepo = userRepo;

        }
        [HttpGet]
        [Route("GetUser/{id}")]
        public IActionResult GetUser(int id)
        {
            User user= _userRepo.GetUser(id);
            return Ok(user);
        

        }
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser(User user)
        {
            _userRepo.Add(user);
            return Ok("Added successfully.");
        }
        [HttpGet]
        [Route("AllUsers")]
        public IActionResult AllUsers() 
        {
            List<User> list=_userRepo.AllUsers();
            return Ok(list);
        }
        //[HttpDelete]
        //[Route("")]
        //public IActionResult Dele
    }
}
