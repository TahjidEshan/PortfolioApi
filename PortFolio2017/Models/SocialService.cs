using PortFolio2017.Enums;

namespace PortFolio2017.Models
{
    public class SocialService : BaseClass
    {
        public SocialLinkType SocialLinkType { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
