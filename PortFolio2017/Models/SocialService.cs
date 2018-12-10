using System;
using System.ComponentModel.DataAnnotations.Schema;
using PortFolio2017.Enums;
namespace PortFolio2017.Models {
    [Table ("SocialService")]
    public class SocialService : BaseClass {
        [Column ("SocialLinkType")]
        public SocialLinkType SocialLinkType { get; set; }

        [Column ("URLId")]
        [ForeignKey ("URL")]
        public Guid URLId { get; set; }
        public virtual URL URL { get; set; }
    }
}