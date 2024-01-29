using TravelDeskProject.IRepo;
using TravelDeskProject.Models;

namespace TravelDeskProject.Repo
{
    public class UserRepo:IUserRepo
    {
        TravelDbContext _db;
        public UserRepo(TravelDbContext db)
        {
            _db = db;
        }
        public void Add(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();

        }
        public User GetUser(int id) 
        { 
            return _db.Users.Where(x => x.UserId == id).FirstOrDefault();
        }
        public List<User> AllUsers()
        {
            return _db.Users.ToList();
        }

        //public void DeleteUser(int id)
        //{
        //    _db.U
        //}

    }
}
