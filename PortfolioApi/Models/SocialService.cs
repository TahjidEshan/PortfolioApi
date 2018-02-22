using PortfolioApi.Enums;

namespace PortfolioApi.Models
{
    public class SocialService : BaseClass
    {
        public SocialLinkType SocialLinkType { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
