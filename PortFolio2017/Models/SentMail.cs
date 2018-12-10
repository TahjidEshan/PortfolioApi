using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models {
    [Table ("SentMail")]
    public class SentMail : BaseClass {
        [Column ("Name")]
        [Required (ErrorMessage = "Please provide your Name")]
        public string Name { get; set; }

        [Column ("EmailAddressId")]
        [ForeignKey ("EmailAddress")]
        public Guid EmailAddressId { get; set; }
        public virtual Email EmailAddress { get; set; }

        [Column ("PhoneId")]
        [ForeignKey ("Phone")]
        public Guid PhoneId { get; set; }
        public virtual Phone Phone { get; set; }

        [Column ("Body")]
        [Required (ErrorMessage = "Please provide your comments")]
        public string Body { get; set; }

        [Column ("Subject")]
        public string Subject { get; set; }

        [Column ("ReceiverId")]
        [ForeignKey ("Receiver")]
        public Guid ReceiverId { get; set; }
        public virtual Email Receiver { get; set; }
    }
}