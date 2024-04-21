using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebService.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        [ForeignKey("Shops")]
        public int ShopId { get; set; }

    }
}
