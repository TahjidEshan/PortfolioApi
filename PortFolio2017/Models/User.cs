using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class User
    {
        [Key]
        public long UserId { get; set; }
        public string UserName { get; set; }
    }
}
