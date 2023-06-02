using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class UserProfile
    {  
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        [MaxLength(11)]
        public string PersonalNumber { get; set; } = null!;

        [ForeignKey("UserId")]

        public virtual User User { get; set; } = null!;
    }
}
