using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models
{
    public class SentMail : BaseClass
    {
        [Required(ErrorMessage = "Please provide your Name")]
        public string Name { get; set; }
        [ForeignKey("EmailAddress")]
        public Guid EmailAddressId { get; set; }
        public virtual Email EmailAddress { get; set; }
        [ForeignKey("Phone")]
        public Guid PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        [Required(ErrorMessage = "Please provide your comments")]
        public string Comments { get; set; }
        public string Subject { get; set; }
        [ForeignKey("ToEmailAddress")]
        public Guid ToEmailAddressId { get; set; }
        public virtual Email ToEmailAddress { get; set; }
    }
}
