using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebWIthoutReact.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        public string USerName { get; set; }
        public string Password { get; set; }
    }
}
