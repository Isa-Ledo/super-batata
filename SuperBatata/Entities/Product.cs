namespace SuperBatata.Api.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PotatoId { get; set; }

        public Order Order { get; set; }
        public Potato Potato { get; set; }

    }
}
