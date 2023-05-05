using UniSystem.Common;

namespace UniSystem.Data.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public int ProfileId { get; set; }
    }
}
