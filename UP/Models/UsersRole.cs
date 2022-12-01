using Microsoft.AspNetCore.Identity;
//using UP.Models.UsersRole;

namespace UP.Models
{
    public class UsersRole
    {
        public int Id { get; set; }
            public string UserId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public IEnumerable<string> Roles { get; set; }
    }
}
