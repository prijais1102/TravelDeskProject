using TravelDeskProject.Models;

namespace TravelDeskProject.IRepo
{
    public interface IUserRepo
    {
        void Add(User user);
        User GetUser(int id);
        List<User> AllUsers();  
    }
}
