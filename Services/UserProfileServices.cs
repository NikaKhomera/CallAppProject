using Data;
using DTO;

namespace Services
{
    public class UserProfileServices
    {
        private ApplicationDbContext _context;
        public UserProfileServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<UserProfile> GetAlluserProfiles()
        {
            return _context.UserProfiles;
        }

        public UserProfile GetProfileById(int id)
        {
            
            var x = _context.UserProfiles.Find(id);
            return x;
        }

        public void DeleteProfile(int id) 
        {
            var profile = _context.UserProfiles.Find(id);
            if(profile != null)
            {
                using (_context)
                {
                    _context.UserProfiles.Remove(profile);
                    _context.SaveChanges();
                }
            }
        }
        public void CreateProfile(UserProfile profile)
        {
            _context.UserProfiles.Add(profile);
            _context.SaveChanges();
        }

        public void EditProfile(UserProfile userProfile)
        {
           var x = _context.UserProfiles.Find(userProfile.Id);
           x.FirstName = userProfile.FirstName;
           x.LastName = userProfile.LastName;
           x.PersonalNumber= userProfile.PersonalNumber;
           _context.UserProfiles.Update(x);
           _context.SaveChanges();
        }
    }
}
