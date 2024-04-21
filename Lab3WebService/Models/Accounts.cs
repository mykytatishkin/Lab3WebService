using System.ComponentModel.DataAnnotations.Schema;

namespace Lab3WebService.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
    }
}
