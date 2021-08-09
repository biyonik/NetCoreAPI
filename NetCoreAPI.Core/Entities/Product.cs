using NetCoreAPI.Core.Abstract;

namespace NetCoreAPI.Core.Entities
{
    public class Product: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string UserId { get; set; }
    }
}