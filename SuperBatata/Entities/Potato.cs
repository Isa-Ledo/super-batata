using System.Collections.Generic;

namespace SuperBatata.Api.Entities
{
    public class Potato
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string UrlImage { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
