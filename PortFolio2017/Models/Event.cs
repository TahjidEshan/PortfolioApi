using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PortFolio2017.Enums;

namespace PortFolio2017.Models
{
    public class Event : BaseClass
    {
        [ForeignKey("Publication")]
        public Guid? PublicationId { get; set; }
        public virtual Publication Publication { get; set; }
        [ForeignKey("Education")]
        public Guid? EducationId { get; set; }
        public virtual Education Education { get; set; }
        [ForeignKey("Work")]
        public Guid? WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
