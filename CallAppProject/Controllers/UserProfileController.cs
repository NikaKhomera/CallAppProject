using DTO;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace CallAppProject.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserProfileController : ControllerBase
    {
        UserProfileServices _services;
        public UserProfileController(UserProfileServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IEnumerable<UserProfile> GetAll()
        {
            var x = _services.GetAlluserProfiles();
            return x;
        }
        [HttpGet("{id}")]

        public UserProfile GetById(int id)
        {
            return _services.GetProfileById(id);
        }
        [HttpDelete("{id}")]
        public void DeleteProfile(int id)
        {
            _services.DeleteProfile(id);
        }
        [HttpPost]
        public void CreateProfile(UserProfile profile)
        {
            _services.CreateProfile(profile);
        }
        [HttpPut]

        public void EditProfile(UserProfile profile)
        {
            _services.EditProfile(profile);
        }
    }
}
