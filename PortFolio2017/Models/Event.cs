using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PortFolio2017.Enums;

namespace PortFolio2017.Models
{
    public class Event : BaseClass
    {
        public LifeEvent LifeEvent { get; set; }
        [ForeignKey("Publication")]
        public long? PublicationId { get; set; }
        public virtual Publication Publication { get; set; }
        [ForeignKey("Education")]
        public long? EducationId { get; set; }
        public virtual Education Education { get; set; }
        [ForeignKey("Work")]
        public long? WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
