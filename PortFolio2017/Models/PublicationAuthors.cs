using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.Models
{
    public class PublicationAuthors : BaseClass
    {
        [ForeignKey("Author")]
        public long AuthorId { get; set; }
        public virtual Author Author { get; set; }
        [ForeignKey("Publication")]
        public long PublicationId { get; set; }
        public virtual Author Publication { get; set; }
    }
}
