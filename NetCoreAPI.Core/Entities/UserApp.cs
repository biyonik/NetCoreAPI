using Microsoft.AspNetCore.Identity;
using NetCoreAPI.Core.Abstract;

namespace NetCoreAPI.Core.Entities
{
    public class UserApp: IdentityUser, IEntity
    {
        public string City { get; set; }
    }
}