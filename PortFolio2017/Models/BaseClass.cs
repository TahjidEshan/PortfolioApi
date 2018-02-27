using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortFolio2017.Models
{
    public class BaseClass
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("CreatedByUser")]
        public long CreatedByUserId { get; set; }
        public virtual User CreatedByUser { get; set; }
        public DateTime? CreatedOn { get; set; }
        [ForeignKey("UpdatedByUser")]
        public long UpdatedByUserId { get; set; }
        public virtual User UpdatedByUser { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
