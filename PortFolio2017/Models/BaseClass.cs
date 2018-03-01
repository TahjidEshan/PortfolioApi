using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models
{
    public class BaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("CreatedByUser")]
        public Guid? CreatedByUserId { get; set; }
        public virtual User CreatedByUser { get; set; }
        public DateTime? CreatedOn { get; set; }
        [ForeignKey("UpdatedByUser")]
        public Guid? UpdatedByUserId { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
