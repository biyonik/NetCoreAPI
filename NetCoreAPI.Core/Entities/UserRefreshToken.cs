using System;
using NetCoreAPI.Core.Abstract;

namespace NetCoreAPI.Core.Entities
{
    public class UserRefreshToken : IEntity
    {
        public string UserId { get; set; }
        public string Code { get; set; }
        public DateTime Expression { get; set; }
    }
}