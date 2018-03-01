using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.Models
{
    public class PublicationAuthor : BaseClass
    {
        [ForeignKey("Author")]
        public Guid AuthorId { get; set; }
        public virtual Author Author { get; set; }
        [ForeignKey("Publication")]
        public Guid PublicationId { get; set; }
        public virtual Publication Publication { get; set; }
    }
}
