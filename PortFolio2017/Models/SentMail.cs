using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models
{
    public class SentMail : BaseClass
    {
        [Required(ErrorMessage = "Please provide your Name")]
        public string Name { get; set; }
        [ForeignKey("EmailAddress")]
        public long EmailAddressId { get; set; }
        public virtual Email EmailAddress { get; set; }
        [ForeignKey("Phone")]
        public long PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        [Required(ErrorMessage = "Please provide your comments")]
        public string Comments { get; set; }
        public string Subject { get; set; }
        [ForeignKey("ToEmailAddress")]
        public long ToEmailAddressId { get; set; }
        public virtual Email ToEmailAddress { get; set; }
    }
}
