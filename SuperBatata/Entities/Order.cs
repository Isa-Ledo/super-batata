using System.Collections.Generic;

namespace SuperBatata.Api.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Client { get; set; }
        public decimal Price { get; set; }
        public string Additional { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
