using System;
using System.ComponentModel.DataAnnotations;

namespace PortFolio2017.Models
{
    public class BaseClass
    {
        [Key]
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
