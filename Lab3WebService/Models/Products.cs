using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebService.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public int Quantity { get; set; }
        [ForeignKey("Shops")]
        public int OwnerId {  get; set; }
    }
}
